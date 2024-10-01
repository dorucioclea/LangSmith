
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedComparativeExperimentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref global::LangSmith.AnyOf<string, object>? name,
            ref global::LangSmith.AnyOf<string, object>? nameContains,
            ref int? offset,
            ref int? limit,
            ref global::LangSmith.SortByComparativeExperimentColumn? sortBy,
            ref bool? sortByDesc);
        partial void PrepareReadSharedComparativeExperimentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::LangSmith.AnyOf<string, object>? name,
            global::LangSmith.AnyOf<string, object>? nameContains,
            int? offset,
            int? limit,
            global::LangSmith.SortByComparativeExperimentColumn? sortBy,
            bool? sortByDesc);
        partial void ProcessReadSharedComparativeExperimentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedComparativeExperimentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Comparative Experiments<br/>
        /// Get all comparative experiments for a given dataset.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Enum for available comparative experiment columns to sort by.
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>> ReadSharedComparativeExperimentsAsync(
            global::System.Guid shareToken,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.AnyOf<string, object>? nameContains = default,
            int? offset = 0,
            int? limit = 100,
            global::LangSmith.SortByComparativeExperimentColumn? sortBy = default,
            bool? sortByDesc = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedComparativeExperimentsArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                name: ref name,
                nameContains: ref nameContains,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/datasets/comparative",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("name", name?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name_contains", nameContains?.ToString() ?? string.Empty) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("sort_by", sortBy?.ToValueString()) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
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
            PrepareReadSharedComparativeExperimentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                name: name,
                nameContains: nameContains,
                offset: offset,
                limit: limit,
                sortBy: sortBy,
                sortByDesc: sortByDesc);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSharedComparativeExperimentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedComparativeExperimentsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}