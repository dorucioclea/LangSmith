
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareCountSharedExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            ref global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf,
            ref global::LangSmith.AnyOf<string, object>? metadata,
            ref global::LangSmith.AnyOf<string, object>? filter);
        partial void PrepareCountSharedExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf,
            global::LangSmith.AnyOf<string, object>? metadata,
            global::LangSmith.AnyOf<string, object>? filter);
        partial void ProcessCountSharedExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCountSharedExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Count Shared Examples<br/>
        /// Count all examples by query params
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<int> CountSharedExamplesAsync(
            global::System.Guid shareToken,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::LangSmith.AnyOf<string, object>? metadata = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCountSharedExamplesArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                id: ref id,
                asOf: ref asOf,
                metadata: ref metadata,
                filter: ref filter);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/examples/count",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id?.ToString() ?? string.Empty) 
                .AddOptionalParameter("as_of", asOf?.ToString() ?? string.Empty) 
                .AddOptionalParameter("metadata", metadata?.ToString() ?? string.Empty) 
                .AddOptionalParameter("filter", filter?.ToString() ?? string.Empty) 
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
            PrepareCountSharedExamplesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                id: id,
                asOf: asOf,
                metadata: metadata,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCountSharedExamplesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCountSharedExamplesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(int?), JsonSerializerContext) as int? ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}