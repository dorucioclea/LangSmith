
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetIsArchived2
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
    public static class ListRepoTagsApiV1ReposTagsGetIsArchived2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetIsArchived2 value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetIsArchived2.True => "true",
                ListRepoTagsApiV1ReposTagsGetIsArchived2.Allow => "allow",
                ListRepoTagsApiV1ReposTagsGetIsArchived2.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetIsArchived2? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListRepoTagsApiV1ReposTagsGetIsArchived2.True,
                "allow" => ListRepoTagsApiV1ReposTagsGetIsArchived2.Allow,
                "false" => ListRepoTagsApiV1ReposTagsGetIsArchived2.False,
                _ => null,
            };
        }
    }
}