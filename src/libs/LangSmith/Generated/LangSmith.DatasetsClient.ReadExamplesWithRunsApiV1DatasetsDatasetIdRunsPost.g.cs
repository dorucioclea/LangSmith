
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::LangSmith.QueryExampleSchemaWithRuns request);
        partial void PrepareReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::LangSmith.QueryExampleSchemaWithRuns request);
        partial void ProcessReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostAsync(
            string datasetId,
            global::LangSmith.QueryExampleSchemaWithRuns request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/runs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.QueryExampleSchemaWithRuns);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.NullableAnyOfIListExampleWithRunsIListExampleWithRunsCH) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionIds"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostAsync(
            string datasetId,
            global::System.Collections.Generic.IList<string> sessionIds,
            global::System.AnyOf<string, object>? comparativeExperimentId = default,
            global::System.AnyOf<global::LangSmith.QueryExampleSchemaWithRunsFilters, object>? filters = default,
            int offset = 0,
            int limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.QueryExampleSchemaWithRuns
            {
                SessionIds = sessionIds,
                ComparativeExperimentId = comparativeExperimentId,
                Filters = filters,
                Offset = offset,
                Limit = limit,
            };

            return await ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}