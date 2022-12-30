using System.Text.RegularExpressions;

namespace CoreAdmin.Infrastructure.Extensions;

/// <summary>
///     String  扩展方法
/// </summary>
public static partial class StringExtensions
{
    /// <summary>
    ///     去掉尾部字符串“Options”
    /// </summary>
    public static string TrimEndOptions(this string me)
    {
        return OptionsRegex().Replace(me, string.Empty);
    }

    [GeneratedRegex("Options$")]
    private static partial Regex OptionsRegex();
}