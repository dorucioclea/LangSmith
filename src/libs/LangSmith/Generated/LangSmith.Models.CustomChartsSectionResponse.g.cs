
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_count")]
        public int? ChartCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionResponse" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="id"></param>
        /// <param name="chartCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomChartsSectionResponse(
            string title,
            global::System.Guid id,
            string? description,
            int? index,
            int? chartCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Id = id;
            this.Description = description;
            this.Index = index;
            this.ChartCount = chartCount;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionResponse" /> class.
        /// </summary>
        public CustomChartsSectionResponse()
        {
        }
    }
}