
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareGetAnnotationQueuesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            ref string? name,
            ref string? nameContains,
            ref int? offset,
            ref int? limit,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void PrepareGetAnnotationQueuesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            string? name,
            string? nameContains,
            int? offset,
            int? limit,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void ProcessGetAnnotationQueuesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAnnotationQueuesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Annotation Queues
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>> GetAnnotationQueuesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            string? name = default,
            string? nameContains = default,
            int? offset = 0,
            int? limit = 100,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetAnnotationQueuesArguments(
                httpClient: _httpClient,
                ids: ids,
                name: ref name,
                nameContains: ref nameContains,
                offset: ref offset,
                limit: ref limit,
                tagValueId: tagValueId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/annotation-queues",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ids", ids, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("name", name) 
                .AddOptionalParameter("name_contains", nameContains) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("tag_value_id", tagValueId, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetAnnotationQueuesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ids: ids,
                name: name,
                nameContains: nameContains,
                offset: offset,
                limit: limit,
                tagValueId: tagValueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetAnnotationQueuesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetAnnotationQueuesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}