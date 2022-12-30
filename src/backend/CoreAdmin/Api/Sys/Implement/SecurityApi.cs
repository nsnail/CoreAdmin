using System.Globalization;
using CoreAdmin.DataContract.DbMap;
using CoreAdmin.DataContract.Dto.Sys.Security;
using CoreAdmin.Infrastructure.Configuration.Options;
using CoreAdmin.Infrastructure.Constant;
using CoreAdmin.Infrastructure.Utils;
using Furion.FriendlyException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;
using NSExt.Extensions;
using SixLabors.ImageSharp;
using Yitter.IdGenerator;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="ISecurityApi" />
public class SecurityApi : ApiBase<ISecurityApi>, ISecurityApi, IScoped
{
    private const    int               _CACHE_EXPIRES_CAPTCHA = 60;
    private const    int               _CACHE_EXPIRES_SMSCODE = 300;
    private const    string            _CACHE_KEY_SMSCODE     = $"{nameof(SendSmsCode)}_{{0}}";
    private const    int               _SEND_LIMIT_SMSCODE    = 60;
    private readonly IDistributedCache _cache;
    private readonly IFreeSql          _freeSql;
    private readonly SecretOptions     _secretOptions;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SecurityApi" /> class.
    /// </summary>
    public SecurityApi(IDistributedCache cache, IOptions<SecretOptions> secretOptions, IFreeSql freeSql)
    {
        _cache         = cache;
        _freeSql       = freeSql;
        _secretOptions = secretOptions.Value;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<GetCaptchaRsp> GetCaptchaImage()
    {
        var baseDir = $@"{AppContext.BaseDirectory}/.data/captcha";

        var (backgroundImage, sliderImage, offsetSaw)
            = await CaptchaImageHelper.CreateSawSliderImage($"{baseDir}/background", $"{baseDir}/template", (1, 101)
                                                          , (1, 7), new Size(50, 50));

        var cacheKey = $"{nameof(GetCaptchaImage)}_{YitIdHelper.NextId()}";
        var captchaData = new GetCaptchaRsp {
                                                CacheKey        = cacheKey
                                              , BackgroundImage = backgroundImage
                                              , SliderImage     = sliderImage
                                            };

        // 将缺口坐标保存到缓存
        await _cache.SetStringAsync(cacheKey, offsetSaw.X.ToString(CultureInfo.InvariantCulture)
                                  , new DistributedCacheEntryOptions {
                                                                         AbsoluteExpirationRelativeToNow
                                                                             = TimeSpan.FromSeconds(
                                                                                 _CACHE_EXPIRES_CAPTCHA)
                                                                     });

        return captchaData;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task SendSmsCode([FromServices] SmsSender smsSender, SendSmsCodeReq req)
    {
        if (!await VerifyCaptcha(req.VerifyCaptchaReq)) {
            throw Oops.Oh(Enums.ErrorCodes.HumanVerification);
        }

        //人机验证通过，删除人机验证缓存
        await _cache.RemoveAsync(req.VerifyCaptchaReq.CacheKey);

        //如果缓存（手机号做key）存在，且创建时间小于1分钟，不得再次发送
        var cacheKey    = string.Format(CultureInfo.InvariantCulture, _CACHE_KEY_SMSCODE, req.Mobile);
        var sentCodeStr = await _cache.GetStringAsync(cacheKey);
        if (sentCodeStr is not null) {
            var sentCode     = sentCodeStr.Object<SmsCodeInfo>();
            var timeInterval = (DateTime.Now - sentCode.CreateTime).TotalSeconds;
            if (timeInterval < _SEND_LIMIT_SMSCODE) {
                throw Oops.Oh( //
                    Enums.ErrorCodes.InvalidOperation
                  , string.Format(CultureInfo.InvariantCulture, Strings.TEMP_TRYSEND_SECS_AFTER
                                , _SEND_LIMIT_SMSCODE - (int)timeInterval));
            }
        }

        // 如果是创建用户，但手机号存在，不得发送。
        if (req.Type == Enums.SmsCodeTypes.CreateUser) {
            if (await _freeSql.Select<TbSysUser>().AnyAsync(a => a.Mobile == req.Mobile)) {
                throw Oops.Oh(Enums.ErrorCodes.InvalidOperation, Strings.MSG_MOBILE_EXISTS);
            }
        }

        var smsCode = new SmsCodeInfo {
                                          Code = new[] { 0, 10000 }.Rand()
                                                                   .ToString(CultureInfo.InvariantCulture)
                                                                   .PadLeft(4, '0')
                                        , CreateTime = DateTime.Now
                                        , Mobile     = req.Mobile
                                      };

        // 调用短信接口发送验证码
        smsSender.SendCode(req.Mobile!.Value, smsCode.Code);

        // 写入缓存，用于校验
        await _cache.SetStringAsync(cacheKey, smsCode.Json()
                                  , new DistributedCacheEntryOptions {
                                                                         AbsoluteExpirationRelativeToNow
                                                                             = TimeSpan.FromSeconds(
                                                                                 _CACHE_EXPIRES_SMSCODE)
                                                                     });
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<bool> VerifyCaptcha(VerifyCaptchaReq req)
    {
        var point = await _cache.GetStringAsync(req.CacheKey);
        if (point is null) {
            return false;
        }

        bool ret;
        try {
            var aesKey = req.CacheKey.Aes(_secretOptions.SecretKeyA)[..32];
            ret = Math.Abs(point.Float() - req.VerifyData.AesDe(aesKey).Float()) < 5f;
        }
        catch {
            ret = false;
        }

        if (!ret) {
            await _cache.RemoveAsync(req.CacheKey);
        }

        return ret;
    }

    /// <inheritdoc />
    [AllowAnonymous]
    public async Task<bool> VerifySmsCode(VerifySmsCodeReq req)
    {
        var cacheKey = string.Format(CultureInfo.InvariantCulture, _CACHE_KEY_SMSCODE, req.Mobile);
        var code     = await _cache.GetStringAsync(cacheKey);
        if (code is null) {
            return false;
        }

        var codeObj = code.Object<SmsCodeInfo>();
        var success = codeObj.Code == req.Code;
        await _cache.RemoveAsync(cacheKey);
        return success;
    }
}