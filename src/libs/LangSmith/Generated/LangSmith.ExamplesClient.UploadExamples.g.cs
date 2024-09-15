using System.Linq;

#nullable enable

namespace LangSmith
{
    public partial class ExamplesClient
    {
        partial void PrepareUploadExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid datasetId,
            global::LangSmith.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost request);
        partial void PrepareUploadExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid datasetId,
            global::LangSmith.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost request);
        partial void ProcessUploadExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> UploadExamplesAsync(
            global::System.Guid datasetId,
            global::LangSmith.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadExamplesArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples/upload/{datasetId}", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{datasetId}"),
                name: "dataset_id");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "file",
                fileName: request.Filename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.InputKeys.Select(x => x))}]"),
                name: "input_keys");
            if (request.OutputKeys != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.OutputKeys.Select(x => x))}]"),
                    name: "output_keys");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadExamplesRequest(
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
            ProcessUploadExamplesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadExamplesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.Example>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.Example> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="outputKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> UploadExamplesAsync(
            global::System.Guid datasetId,
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::System.Collections.Generic.IList<string>? outputKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost
            {
                File = file,
                Filename = filename,
                InputKeys = inputKeys,
                OutputKeys = outputKeys,
            };

            return await UploadExamplesAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}