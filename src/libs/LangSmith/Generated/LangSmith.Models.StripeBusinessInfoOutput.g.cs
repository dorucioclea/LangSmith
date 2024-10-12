
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeBusinessInfoOutput
    {
        /// <summary>
        /// Stripe customer billing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_info")]
        public global::LangSmith.StripeBusinessBillingInfo? CompanyInfo { get; set; }

        /// <summary>
        /// Stripe tax ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_id")]
        public global::LangSmith.StripeTaxId? TaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_email")]
        public string? InvoiceEmail { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_business")]
        public bool? IsBusiness { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}