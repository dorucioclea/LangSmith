
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request body for creating or updating a usage limit.
    /// </summary>
    public sealed partial class UpsertUsageLimit
    {
        /// <summary>
        /// Type of usage limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UsageLimitType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.UsageLimitType2 LimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LimitValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}