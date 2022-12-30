#pragma warning disable CS1591

namespace CoreAdmin.Infrastructure.Constant;

/// <summary>
///     值类型常量表（public类型会通过接口暴露给前端）
/// </summary>
public static class Values
{
    public const int PAGE_NO_MAX   = 10000; //最大页码
    public const int PAGE_NO_MIN   = 1;     //最小页码
    public const int PAGE_SIZE_MAX = 100;   //最大分页容量
    public const int PAGE_SIZE_MIN = 1;     //最小分页容量
}