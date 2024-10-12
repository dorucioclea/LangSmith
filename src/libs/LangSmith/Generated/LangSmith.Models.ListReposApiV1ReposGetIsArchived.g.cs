
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetIsArchived
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetIsArchivedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetIsArchived value)
        {
            return value switch
            {
                ListReposApiV1ReposGetIsArchived.True => "true",
                ListReposApiV1ReposGetIsArchived.Allow => "allow",
                ListReposApiV1ReposGetIsArchived.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetIsArchived? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListReposApiV1ReposGetIsArchived.True,
                "allow" => ListReposApiV1ReposGetIsArchived.Allow,
                "false" => ListReposApiV1ReposGetIsArchived.False,
                _ => null,
            };
        }
    }
}