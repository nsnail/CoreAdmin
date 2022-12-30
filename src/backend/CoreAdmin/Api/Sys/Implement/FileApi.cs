using System.Globalization;
using CoreAdmin.Infrastructure.Configuration.Options;
using CoreAdmin.Infrastructure.Constant;
using Furion.FriendlyException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Yitter.IdGenerator;

namespace CoreAdmin.Api.Sys.Implement;

/// <inheritdoc cref="IFileApi" />
public class FileApi : ApiBase<IFileApi>, IFileApi
{
    private const    string        _请上传文件  = "请上传文件";
    private const    string        _文件格式错误 = "文件格式错误";
    private const    string        _文件过大   = "文件过大";
    private readonly UploadOptions _uploadOptions;

    /// <summary>
    ///     Initializes a new instance of the <see cref="FileApi" /> class.
    /// </summary>
    public FileApi(IOptions<UploadOptions> uploadOptions)
    {
        _uploadOptions = uploadOptions.Value;
    }

    /// <inheritdoc />
    public async Task Upload([FromForm] IFormFile file)
    {
        if (file is null || file.Length < 1) {
            throw Oops.Oh(Enums.ErrorCodes.InvalidInput, _请上传文件);
        }

        if (!_uploadOptions.ContentType.Contains(file.ContentType)) {
            throw Oops.Oh(Enums.ErrorCodes.InvalidOperation, _文件格式错误);
        }

        if (!(file.Length <= _uploadOptions.MaxSize)) {
            throw Oops.Oh(Enums.ErrorCodes.InvalidOperation, _文件过大);
        }

        var dateTimeFormat = _uploadOptions.DateTimeFormat is null
            ? string.Empty
            : DateTime.Now.ToString(_uploadOptions.DateTimeFormat, CultureInfo.InvariantCulture);

        var format = _uploadOptions.Format ?? string.Empty;

        var relativePath = Path.Combine(dateTimeFormat, format);

        var fileDirectory = Path.Combine(_uploadOptions.UploadPath, relativePath);
        if (!Directory.Exists(fileDirectory)) {
            Directory.CreateDirectory(fileDirectory);
        }

        var ext      = Path.GetExtension(file.FileName).TrimStart('.');
        var saveName = $"{YitIdHelper.NextId()}.{ext}";

        var             filePath = Path.Combine(_uploadOptions.UploadPath, relativePath, saveName);
        await using var stream   = File.Create(filePath);
        await file.CopyToAsync(stream, CancellationToken.None);
    }
}