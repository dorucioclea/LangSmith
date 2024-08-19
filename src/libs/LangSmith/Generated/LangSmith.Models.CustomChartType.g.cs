
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for custom chart types.
    /// </summary>
    public enum CustomChartType
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Bar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartType value)
        {
            return value switch
            {
                CustomChartType.Line => "line",
                CustomChartType.Bar => "bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartType? ToEnum(string value)
        {
            return value switch
            {
                "line" => CustomChartType.Line,
                "bar" => CustomChartType.Bar,
                _ => null,
            };
        }
    }
}