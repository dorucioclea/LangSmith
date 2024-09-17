
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Timedelta input.
    /// </summary>
    public sealed partial class TimedeltaInput
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        public int? Days { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        public int? Minutes { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        public int? Hours { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}