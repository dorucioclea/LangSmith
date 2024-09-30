
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAuthProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomOidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthProvider value)
        {
            return value switch
            {
                OAuthProvider.CustomOidc => "custom-oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-oidc" => OAuthProvider.CustomOidc,
                _ => null,
            };
        }
    }
}