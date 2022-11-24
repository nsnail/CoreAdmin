using NSExt.Extensions;

namespace CoreAdmin.DataContracts;

/// <summary>
///     Dto 基类
/// </summary>
public abstract record DataContract
{
    /// <inheritdoc />
    public override string ToString()
    {
        return this.Json();
    }
}