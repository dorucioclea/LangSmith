
#nullable enable

namespace LangSmith
{
    public partial class ReposClient
    {
        partial void PrepareListRepoTagsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            ref string? tenantHandle,
            ref global::System.Guid? tenantId,
            ref string? query,
            ref bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            ref global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? isArchived,
            ref global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? isPublic,
            ref string? upstreamRepoOwner,
            ref string? upstreamRepoHandle,
            ref bool? matchPrefix,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void PrepareListRepoTagsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            string? tenantHandle,
            global::System.Guid? tenantId,
            string? query,
            bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? isArchived,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? isPublic,
            string? upstreamRepoOwner,
            string? upstreamRepoHandle,
            bool? matchPrefix,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void ProcessListRepoTagsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRepoTagsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Repo Tags<br/>
        /// Get all repo tags.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tenantHandle"></param>
        /// <param name="tenantId"></param>
        /// <param name="query"></param>
        /// <param name="hasCommits"></param>
        /// <param name="tags"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPublic"></param>
        /// <param name="upstreamRepoOwner"></param>
        /// <param name="upstreamRepoHandle"></param>
        /// <param name="matchPrefix">
        /// Default Value: false
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListTagsResponse> ListRepoTagsAsync(
            int? limit = 20,
            int? offset = 0,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? isArchived = default,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            bool? matchPrefix = false,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRepoTagsArguments(
                httpClient: _httpClient,
                limit: ref limit,
                offset: ref offset,
                tenantHandle: ref tenantHandle,
                tenantId: ref tenantId,
                query: ref query,
                hasCommits: ref hasCommits,
                tags: tags,
                isArchived: ref isArchived,
                isPublic: ref isPublic,
                upstreamRepoOwner: ref upstreamRepoOwner,
                upstreamRepoHandle: ref upstreamRepoHandle,
                matchPrefix: ref matchPrefix,
                tagValueId: tagValueId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/repos/tags",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("tenant_handle", tenantHandle) 
                .AddOptionalParameter("tenant_id", tenantId?.ToString()) 
                .AddOptionalParameter("query", query) 
                .AddOptionalParameter("has_commits", hasCommits?.ToString()) 
                .AddOptionalParameter("tags", tags, delimiter: ",", explode: true) 
                .AddOptionalParameter("is_archived", isArchived?.ToValueString()) 
                .AddOptionalParameter("is_public", isPublic?.ToValueString()) 
                .AddOptionalParameter("upstream_repo_owner", upstreamRepoOwner) 
                .AddOptionalParameter("upstream_repo_handle", upstreamRepoHandle) 
                .AddOptionalParameter("match_prefix", matchPrefix?.ToString()) 
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
            PrepareListRepoTagsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                offset: offset,
                tenantHandle: tenantHandle,
                tenantId: tenantId,
                query: query,
                hasCommits: hasCommits,
                tags: tags,
                isArchived: isArchived,
                isPublic: isPublic,
                upstreamRepoOwner: upstreamRepoOwner,
                upstreamRepoHandle: upstreamRepoHandle,
                matchPrefix: matchPrefix,
                tagValueId: tagValueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListRepoTagsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRepoTagsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.ListTagsResponse), JsonSerializerContext) as global::LangSmith.ListTagsResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}