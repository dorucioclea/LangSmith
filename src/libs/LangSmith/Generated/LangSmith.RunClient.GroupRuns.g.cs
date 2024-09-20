
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareGroupRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.AnyOf<string, object>? accept,
            global::LangSmith.RunGroupRequest request);
        partial void PrepareGroupRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.AnyOf<string, object>? accept,
            global::LangSmith.RunGroupRequest request);
        partial void ProcessGroupRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGroupRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Group Runs<br/>
        /// Get runs grouped by an expression
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.GroupRunsApiV1RunsGroupPostResponse> GroupRunsAsync(
            global::LangSmith.RunGroupRequest request,
            global::LangSmith.AnyOf<string, object>? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGroupRunsArguments(
                httpClient: _httpClient,
                accept: ref accept,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs/group",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGroupRunsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                accept: accept,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGroupRunsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGroupRunsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.GroupRunsApiV1RunsGroupPostResponse), JsonSerializerContext) as global::LangSmith.GroupRunsApiV1RunsGroupPostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Group Runs<br/>
        /// Get runs grouped by an expression
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="filter"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.GroupRunsApiV1RunsGroupPostResponse> GroupRunsAsync(
            global::System.Guid sessionId,
            global::LangSmith.AnyOf<string, object>? accept = default,
            global::LangSmith.RunGroupBy groupBy = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            int? offset = 0,
            int? limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.RunGroupRequest
            {
                SessionId = sessionId,
                GroupBy = groupBy,
                Filter = filter,
                StartTime = startTime,
                EndTime = endTime,
                Offset = offset,
                Limit = limit,
            };

            return await GroupRunsAsync(
                accept: accept,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}