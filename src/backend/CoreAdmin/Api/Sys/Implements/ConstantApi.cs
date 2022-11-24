using System.Text.Json;
using CoreAdmin.DataContracts.Dto;
using CoreAdmin.Infrastructure.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSExt.Extensions;

namespace CoreAdmin.Api.Sys.Implements;

/// <inheritdoc cref="IConstantApi" />
[AllowAnonymous]
public class ConstantApi : ApiBase<IConstantApi>, IConstantApi
{
    /// <inheritdoc />
    public object GetEnums()
    {
        return typeof(Enums).GetNestedTypes()
                            .ToDictionary(x => x.Name,
                                          x => x.GetEnumValues()
                                                .Cast<object>()
                                                .ToDictionary(x.GetEnumName,
                                                              y => new {
                                                                  Value = y,
                                                                  Desc  = ((Enum)y).Desc()
                                                              }));
    }

    /// <inheritdoc />
    [NonUnify]
    public IActionResult GetStrings()
    {
        var jsonOptions = default(JsonSerializerOptions).NewJsonSerializerOptions();
        jsonOptions.DictionaryKeyPolicy = null;
        return new JsonResult(new RestfulInfo<object> {
                                  Code = 0,
                                  Data = typeof(Strings).GetFields()
                                                        .ToDictionary(x => x.Name.ToString(),
                                                                      x => x.GetValue(null)?.ToString())
                              },
                              jsonOptions);
    }
}