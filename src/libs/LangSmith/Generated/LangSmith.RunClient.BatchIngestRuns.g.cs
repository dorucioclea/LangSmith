
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareBatchIngestRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.BatchIngestRunsRequest request);
        partial void PrepareBatchIngestRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.BatchIngestRunsRequest request);
        partial void ProcessBatchIngestRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBatchIngestRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Batch Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.BatchIngestRunsApiV1RunsBatchPostResponse> BatchIngestRunsAsync(
            global::LangSmith.BatchIngestRunsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareBatchIngestRunsArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs/batch",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBatchIngestRunsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessBatchIngestRunsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessBatchIngestRunsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.BatchIngestRunsApiV1RunsBatchPostResponse), JsonSerializerContext) as global::LangSmith.BatchIngestRunsApiV1RunsBatchPostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Batch Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="post"></param>
        /// <param name="patch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.BatchIngestRunsApiV1RunsBatchPostResponse> BatchIngestRunsAsync(
            global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPostItem>? post = default,
            global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPatchItem>? patch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BatchIngestRunsRequest
            {
                Post = post,
                Patch = patch,
            };

            return await BatchIngestRunsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}