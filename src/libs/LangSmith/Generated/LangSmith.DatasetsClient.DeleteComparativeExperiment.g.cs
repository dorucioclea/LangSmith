
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareDeleteComparativeExperimentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid comparativeExperimentId);
        partial void PrepareDeleteComparativeExperimentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid comparativeExperimentId);
        partial void ProcessDeleteComparativeExperimentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteComparativeExperimentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Comparative Experiment<br/>
        /// Delete a specific comparative experiment.
        /// </summary>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse> DeleteComparativeExperimentAsync(
            global::System.Guid comparativeExperimentId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteComparativeExperimentArguments(
                httpClient: _httpClient,
                comparativeExperimentId: ref comparativeExperimentId);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/datasets/comparative/{comparativeExperimentId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteComparativeExperimentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                comparativeExperimentId: comparativeExperimentId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteComparativeExperimentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteComparativeExperimentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse), JsonSerializerContext) as global::LangSmith.DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}