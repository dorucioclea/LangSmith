
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Query params for run endpoints.
    /// </summary>
    public sealed partial class FilterQueryParamsForRunSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::System.Guid? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run")]
        public global::System.Guid? ParentRun { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunTypeEnumJsonConverter))]
        public global::LangSmith.RunTypeEnum? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceExample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_order")]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_root")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Enum for run data source types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter))]
        public global::LangSmith.RunsFilterDataSourceTypeEnum? DataSourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryParamsForRunSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType">
        /// Enum for run types.
        /// </param>
        /// <param name="session"></param>
        /// <param name="referenceExample"></param>
        /// <param name="executionOrder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="isRoot"></param>
        /// <param name="dataSourceType">
        /// Enum for run data source types.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FilterQueryParamsForRunSchema(
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            global::System.Guid? trace,
            global::System.Guid? parentRun,
            global::LangSmith.RunTypeEnum? runType,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceExample,
            int? executionOrder,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            bool? error,
            string? query,
            string? filter,
            string? traceFilter,
            string? treeFilter,
            bool? isRoot,
            global::LangSmith.RunsFilterDataSourceTypeEnum? dataSourceType)
        {
            this.Id = id;
            this.Trace = trace;
            this.ParentRun = parentRun;
            this.RunType = runType;
            this.Session = session;
            this.ReferenceExample = referenceExample;
            this.ExecutionOrder = executionOrder;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Error = error;
            this.Query = query;
            this.Filter = filter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
            this.IsRoot = isRoot;
            this.DataSourceType = dataSourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryParamsForRunSchema" /> class.
        /// </summary>
        public FilterQueryParamsForRunSchema()
        {
        }
    }
}