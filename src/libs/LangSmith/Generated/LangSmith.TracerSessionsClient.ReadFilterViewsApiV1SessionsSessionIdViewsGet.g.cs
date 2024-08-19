
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {
        partial void PrepareReadFilterViewsApiV1SessionsSessionIdViewsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId);
        partial void PrepareReadFilterViewsApiV1SessionsSessionIdViewsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId);
        partial void ProcessReadFilterViewsApiV1SessionsSessionIdViewsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadFilterViewsApiV1SessionsSessionIdViewsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Filter Views<br/>
        /// Get all filter views for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FilterView>> ReadFilterViewsApiV1SessionsSessionIdViewsGetAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadFilterViewsApiV1SessionsSessionIdViewsGetArguments(
                httpClient: _httpClient,
                sessionId: ref sessionId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions/{sessionId}/views", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadFilterViewsApiV1SessionsSessionIdViewsGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sessionId: sessionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadFilterViewsApiV1SessionsSessionIdViewsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadFilterViewsApiV1SessionsSessionIdViewsGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListFilterView) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}