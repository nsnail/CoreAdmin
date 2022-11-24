﻿#pragma warning disable CS1591
namespace CoreAdmin.Infrastructure.Constant;

/// <summary>
///     字符串常量表（public类型会通过接口暴露给前端）
/// </summary>
public static class Strings
{
    public const string DESC_MODIFIED_TIME     = "修改时间";
    public const string DSC_CREATED_TIME       = "创建时间";
    public const string DSC_CREATED_USER_ID    = "创建者Id";
    public const string DSC_CREATED_USER_NAME  = "创建者";
    public const string DSC_ID                 = "主键Id";
    public const string DSC_IS_DELETED         = "是否删除";
    public const string DSC_MODIFIED_USER_ID   = "修改者Id";
    public const string DSC_MODIFIED_USER_NAME = "修改者";
    public const string DSC_VERSION            = "版本";


    public const string FLAG_ACCESS_TOKEN = "ACCESS-TOKEN";

    public const string FLAG_HTTP_METHOD_CONNECT = "CONNECT";
    public const string FLAG_HTTP_METHOD_DELETE  = "DELETE";
    public const string FLAG_HTTP_METHOD_GET     = "GET";
    public const string FLAG_HTTP_METHOD_HEAD    = "HEAD";
    public const string FLAG_HTTP_METHOD_OPTIONS = "OPTIONS";
    public const string FLAG_HTTP_METHOD_PATCH   = "PATCH";
    public const string FLAG_HTTP_METHOD_POST    = "POST";
    public const string FLAG_HTTP_METHOD_PUT     = "PUT";
    public const string FLAG_HTTP_METHOD_TRACE   = "TRACE";
    public const string FLAG_X_ACCESS_TOKEN      = "X-ACCESS-TOKEN";


    public const string FMT_YYYY_MM_DD = "yyyy-MM-dd";

    public const string FMT_YYYY_MM_DD_HH_MM_SS = "yyyy-MM-dd HH:mm:ss";


    public const string FMT_YYYYMMDD = "yyyyMMdd";


    public const string FMT_YYYYMMDDHHMMSSFFFZZZZ = "yyyyMMddHHmmssfffzzz";


    public const string MSG_ERROR_INVALID_INPUT = "无效输入";

    public const string MSG_ERROR_UNKNOWN      = "未知错误";
    public const string MSG_HUMAN_VERIFICATION = "人机验证";
    public const string MSG_IDENTITY_MISSING   = "未登录";
    public const string MSG_INVALID_OPERATION  = "无效操作";

    public const string MSG_MOBILE_EXISTS   = "手机号已被注册";
    public const string MSG_MOBILE_USEFUL   = "能正常使用的手机号码";
    public const string MSG_NO_PERMISSIONS  = "权限不足";
    public const string MSG_PASSWORD_STRONG = "8位以上数字字母组合";
    public const string MSG_SMSCODE_NUMBER  = "验证码短信中的4位数字";

    public const string MSG_SMSCODE_WRONG        = "短信验证码不正确";
    public const string MSG_UNAME_PASSWORD_WRONG = "用户名或密码错误";

    public const string MSG_USER_DISABLED   = "用户已禁用";
    public const string MSG_USERNAME_STRONG = "5位以上（字母数字下划线）";


    public const string REGEX_MOBILE = """^1(3\d|4[5-9]|5[0-35-9]|6[6]|7[2-8]|8\d|9[0-35-9])\d{8}$""";


    public const string REGEX_PASSWORD = """^(?![0-9]+$)(?![a-zA-Z]+$).{8,20}$""";
    public const string REGEX_SMSCODE  = """^\d{4}$""";
    public const string REGEX_USERNAME = """^[a-zA-Z0-9_]{5,20}$""";

    public const string TEMP_LOG_OUPUT =
        "[{Timestamp:HH:mm:ss.fff} {Level:u3} {SourceContext,64}] {Message:lj}{NewLine}{Exception}";

    public const string TEMP_SMSCODE = "您正在进行 {0} 操作，验证码为：{1}，5分钟内有效，如非本人操作，请忽略。";

    public const string TEMP_TRYSEND_SECS_AFTER = "{0} 秒后，可再次发送";


    public const string UA_MOBILE =
        "Mozilla/5.0 (Linux; Android 9; Redmi Note 8 Pro Build/PPR1.180610.011; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/78.0.3904.96 Mobile Safari/537.36";


    public const string UA_PC =
        "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
}