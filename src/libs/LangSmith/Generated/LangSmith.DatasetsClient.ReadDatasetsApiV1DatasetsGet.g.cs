
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareReadDatasetsApiV1DatasetsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref global::System.AnyOf<global::LangSmith.DataType2?, object>? dataType,
            ref global::System.AnyOf<string?, object>? name,
            ref global::System.AnyOf<string?, object>? nameContains,
            ref global::System.AnyOf<string?, object>? metadata,
            ref int offset,
            ref int limit,
            ref global::System.AllOf<global::LangSmith.SortByDatasetColumn?>? sortBy,
            ref bool sortByDesc,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId);
        partial void PrepareReadDatasetsApiV1DatasetsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<global::LangSmith.DataType2?, object>? dataType,
            global::System.AnyOf<string?, object>? name,
            global::System.AnyOf<string?, object>? nameContains,
            global::System.AnyOf<string?, object>? metadata,
            int offset,
            int limit,
            global::System.AllOf<global::LangSmith.SortByDatasetColumn?>? sortBy,
            bool sortByDesc,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId);
        partial void ProcessReadDatasetsApiV1DatasetsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadDatasetsApiV1DatasetsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Datasets<br/>
        /// Get all datasets by query params and owner.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Default Value: last_session_start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Dataset>> ReadDatasetsApiV1DatasetsGetAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<global::LangSmith.DataType2?, object>? dataType,
            global::System.AnyOf<string?, object>? name,
            global::System.AnyOf<string?, object>? nameContains,
            global::System.AnyOf<string?, object>? metadata,
            int offset,
            int limit,
            global::System.AllOf<global::LangSmith.SortByDatasetColumn?>? sortBy,
            bool sortByDesc,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadDatasetsApiV1DatasetsGetArguments(
                httpClient: _httpClient,
                id: ref id,
                dataType: ref dataType,
                name: ref name,
                nameContains: ref nameContains,
                metadata: ref metadata,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                tagValueId: ref tagValueId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets?id={id}&data_type={dataType}&name={name}&name_contains={nameContains}&metadata={metadata}&offset={offset}&limit={limit}&sort_by={sortBy}&sort_by_desc={sortByDesc}&tag_value_id={tagValueId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadDatasetsApiV1DatasetsGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                dataType: dataType,
                name: name,
                nameContains: nameContains,
                metadata: metadata,
                offset: offset,
                limit: limit,
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
            ProcessReadDatasetsApiV1DatasetsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadDatasetsApiV1DatasetsGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListDataset) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}