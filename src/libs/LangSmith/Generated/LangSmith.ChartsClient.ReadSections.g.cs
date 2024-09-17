
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareReadSectionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            ref global::LangSmith.AnyOf<string, object>? titleContains,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids,
            ref global::LangSmith.AnyOf<string, object>? sortBy,
            ref global::LangSmith.AnyOf<bool?, object>? sortByDesc,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId);
        partial void PrepareReadSectionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            global::LangSmith.AnyOf<string, object>? titleContains,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids,
            global::LangSmith.AnyOf<string, object>? sortBy,
            global::LangSmith.AnyOf<bool?, object>? sortByDesc,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId);
        partial void ProcessReadSectionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSectionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Sections<br/>
        /// Get all sections for the tenant.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="titleContains"></param>
        /// <param name="ids"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>> ReadSectionsAsync(
            int? limit = 100,
            int? offset = 0,
            global::LangSmith.AnyOf<string, object>? titleContains = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids = default,
            global::LangSmith.AnyOf<string, object>? sortBy = default,
            global::LangSmith.AnyOf<bool?, object>? sortByDesc = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSectionsArguments(
                httpClient: _httpClient,
                limit: ref limit,
                offset: ref offset,
                titleContains: ref titleContains,
                ids: ref ids,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                tagValueId: ref tagValueId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/charts/section?limit={limit}&offset={offset}&title_contains={titleContains}&ids={ids}&sort_by={sortBy}&sort_by_desc={sortByDesc}&tag_value_id={tagValueId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSectionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                offset: offset,
                titleContains: titleContains,
                ids: ids,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                tagValueId: tagValueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSectionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSectionsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}