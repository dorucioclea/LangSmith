
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Information about an organization's billing configuration.
    /// </summary>
    public sealed partial class OrganizationBillingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OrganizationConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_to_stripe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConnectedToStripe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_to_metronome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConnectedToMetronome { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter))]
        public global::LangSmith.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// Stripe customer billing info.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public global::LangSmith.StripePaymentMethodInfo? PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_billing_period")]
        public global::System.DateTime? EndOfBillingPeriod { get; set; }

        /// <summary>
        /// Customer visible plan information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_plan")]
        public global::LangSmith.CustomerVisiblePlanInfo? CurrentPlan { get; set; }

        /// <summary>
        /// Customer visible plan information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upcoming_plan")]
        public global::LangSmith.CustomerVisiblePlanInfo? UpcomingPlan { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}