
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetIsArchived
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
    public static class ListRepoTagsApiV1ReposTagsGetIsArchivedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetIsArchived value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetIsArchived.True => "true",
                ListRepoTagsApiV1ReposTagsGetIsArchived.Allow => "allow",
                ListRepoTagsApiV1ReposTagsGetIsArchived.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetIsArchived? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListRepoTagsApiV1ReposTagsGetIsArchived.True,
                "allow" => ListRepoTagsApiV1ReposTagsGetIsArchived.Allow,
                "false" => ListRepoTagsApiV1ReposTagsGetIsArchived.False,
                _ => null,
            };
        }
    }
}