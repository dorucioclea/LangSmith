
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRunsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RunSchema> Runs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string?> Cursors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed_query")]
        public string? ParsedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="cursors"></param>
        /// <param name="parsedQuery"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListRunsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.RunSchema> runs,
            global::System.Collections.Generic.Dictionary<string, string?> cursors,
            string? parsedQuery)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.Cursors = cursors ?? throw new global::System.ArgumentNullException(nameof(cursors));
            this.ParsedQuery = parsedQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        public ListRunsResponse()
        {
        }
    }
}