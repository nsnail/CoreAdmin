using NSExt.Extensions;

namespace CoreAdmin.DataContract;

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