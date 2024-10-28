
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: SystemMessageChunk
    /// </summary>
    public enum SystemMessageChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemMessageChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageChunkType value)
        {
            return value switch
            {
                SystemMessageChunkType.SystemMessageChunk => "SystemMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageChunkType? ToEnum(string value)
        {
            return value switch
            {
                "SystemMessageChunk" => SystemMessageChunkType.SystemMessageChunk,
                _ => null,
            };
        }
    }
}