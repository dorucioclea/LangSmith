
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Information about an organization.
    /// </summary>
    public sealed partial class OrganizationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? DisplayName { get; set; }

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OrganizationConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.PaymentPlanTier?, object>? Tier { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool ReachedMaxWorkspaces { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool Disabled { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        public bool SsoOnly { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_login_slug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? SsoLoginSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}