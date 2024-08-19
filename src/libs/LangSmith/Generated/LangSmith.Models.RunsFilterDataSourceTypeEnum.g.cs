
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for run data source types.
    /// </summary>
    public enum RunsFilterDataSourceTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Current,
        /// <summary>
        /// 
        /// </summary>
        Historical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsFilterDataSourceTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsFilterDataSourceTypeEnum value)
        {
            return value switch
            {
                RunsFilterDataSourceTypeEnum.Current => "current",
                RunsFilterDataSourceTypeEnum.Historical => "historical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsFilterDataSourceTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "current" => RunsFilterDataSourceTypeEnum.Current,
                "historical" => RunsFilterDataSourceTypeEnum.Historical,
                _ => null,
            };
        }
    }
}