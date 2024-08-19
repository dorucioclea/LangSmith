
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            global::LangSmith.BodyParamsForRunSchema request);
        partial void PrepareQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::LangSmith.BodyParamsForRunSchema request);
        partial void ProcessQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListPublicDatasetRunsResponse> QuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostAsync(
            string shareToken,
            global::LangSmith.BodyParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/runs/query", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.BodyParamsForRunSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessQuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ListPublicDatasetRunsResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Query Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType"></param>
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
        /// <param name="dataSourceType"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, session_id, serialized, reference_example_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, child_run_ids, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade]
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListPublicDatasetRunsResponse> QuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostAsync(
            string shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id = default,
            global::System.AnyOf<string, object>? trace = default,
            global::System.AnyOf<string, object>? parentRun = default,
            global::System.AnyOf<global::LangSmith.RunTypeEnum?, object>? runType = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? session = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? referenceExample = default,
            global::System.AnyOf<int?, object>? executionOrder = default,
            global::System.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::System.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::System.AnyOf<bool?, object>? error = default,
            global::System.AnyOf<string?, object>? query = default,
            global::System.AnyOf<string?, object>? filter = default,
            global::System.AnyOf<string?, object>? traceFilter = default,
            global::System.AnyOf<string?, object>? treeFilter = default,
            global::System.AnyOf<bool?, object>? isRoot = default,
            global::System.AnyOf<global::LangSmith.RunsFilterDataSourceTypeEnum?, object>? dataSourceType = default,
            global::System.AnyOf<string?, object>? cursor = default,
            int limit = 100,
            global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? select = default,
            global::System.AllOf<global::LangSmith.RunDateOrder?>? order = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BodyParamsForRunSchema
            {
                Id = id,
                Trace = trace,
                ParentRun = parentRun,
                RunType = runType,
                Session = session,
                ReferenceExample = referenceExample,
                ExecutionOrder = executionOrder,
                StartTime = startTime,
                EndTime = endTime,
                Error = error,
                Query = query,
                Filter = filter,
                TraceFilter = traceFilter,
                TreeFilter = treeFilter,
                IsRoot = isRoot,
                DataSourceType = dataSourceType,
                Cursor = cursor,
                Limit = limit,
                Select = select,
                Order = order,
            };

            return await QuerySharedDatasetRunsApiV1PublicShareTokenDatasetsRunsQueryPostAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}