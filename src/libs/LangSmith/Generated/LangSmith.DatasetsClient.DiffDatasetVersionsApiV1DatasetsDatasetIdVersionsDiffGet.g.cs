
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref global::System.AnyOf<global::System.DateTime?, string> fromVersion,
            ref global::System.AnyOf<global::System.DateTime?, string> toVersion);
        partial void PrepareDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::System.AnyOf<global::System.DateTime?, string> fromVersion,
            global::System.AnyOf<global::System.DateTime?, string> toVersion);
        partial void ProcessDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Diff Dataset Versions<br/>
        /// Get diff between two dataset versions.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="fromVersion"></param>
        /// <param name="toVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DatasetDiffInfo> DiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetAsync(
            string datasetId,
            global::System.AnyOf<global::System.DateTime?, string> fromVersion,
            global::System.AnyOf<global::System.DateTime?, string> toVersion,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                fromVersion: ref fromVersion,
                toVersion: ref toVersion);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/versions/diff?from_version={fromVersion}&to_version={toVersion}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                fromVersion: fromVersion,
                toVersion: toVersion);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDiffDatasetVersionsApiV1DatasetsDatasetIdVersionsDiffGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DatasetDiffInfo) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}