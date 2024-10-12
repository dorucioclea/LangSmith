
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetIsPublic
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetIsPublicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetIsPublic value)
        {
            return value switch
            {
                ListReposApiV1ReposGetIsPublic.True => "true",
                ListReposApiV1ReposGetIsPublic.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetIsPublic? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListReposApiV1ReposGetIsPublic.True,
                "false" => ListReposApiV1ReposGetIsPublic.False,
                _ => null,
            };
        }
    }
}