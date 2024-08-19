
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetSortDirectionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetSortDirectionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetSortDirectionVariant1 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetSortDirectionVariant1.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetSortDirectionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListReposApiV1ReposGetSortDirectionVariant1.Asc,
                _ => null,
            };
        }
    }
}