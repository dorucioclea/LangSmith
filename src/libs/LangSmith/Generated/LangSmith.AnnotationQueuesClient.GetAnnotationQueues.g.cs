
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareGetAnnotationQueuesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids,
            ref global::LangSmith.AnyOf<string, object>? name,
            ref global::LangSmith.AnyOf<string, object>? nameContains,
            ref int offset,
            ref int limit,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId);
        partial void PrepareGetAnnotationQueuesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids,
            global::LangSmith.AnyOf<string, object>? name,
            global::LangSmith.AnyOf<string, object>? nameContains,
            int offset,
            int limit,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId);
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
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids = default,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.AnyOf<string, object>? nameContains = default,
            int offset = 0,
            int limit = 100,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetAnnotationQueuesArguments(
                httpClient: _httpClient,
                ids: ref ids,
                name: ref name,
                nameContains: ref nameContains,
                offset: ref offset,
                limit: ref limit,
                tagValueId: ref tagValueId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues?ids={ids}&name={name}&name_contains={nameContains}&offset={offset}&limit={limit}&tag_value_id={tagValueId}", global::System.UriKind.RelativeOrAbsolute));

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