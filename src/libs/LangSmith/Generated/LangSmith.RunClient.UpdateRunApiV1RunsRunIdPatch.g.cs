
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareUpdateRunApiV1RunsRunIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string runId,
            global::LangSmith.UpdateRunRequest request);
        partial void PrepareUpdateRunApiV1RunsRunIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string runId,
            global::LangSmith.UpdateRunRequest request);
        partial void ProcessUpdateRunApiV1RunsRunIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRunApiV1RunsRunIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunApiV1RunsRunIdPatchAsync(
            string runId,
            global::LangSmith.UpdateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRunApiV1RunsRunIdPatchArguments(
                httpClient: _httpClient,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/{runId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.UpdateRunRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRunApiV1RunsRunIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                runId: runId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateRunApiV1RunsRunIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRunApiV1RunsRunIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateRunApiV1RunsRunIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="parentRunId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="extra"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunApiV1RunsRunIdPatchAsync(
            string runId,
            global::System.OneOf<string, object>? traceId = default,
            global::System.OneOf<string?, object>? dottedOrder = default,
            global::System.OneOf<string, object>? parentRunId = default,
            global::System.OneOf<string?, double?, object>? endTime = default,
            global::System.OneOf<string?, object>? error = default,
            global::System.OneOf<global::LangSmith.UpdateRunRequestInputs, object>? inputs = default,
            global::System.OneOf<global::LangSmith.UpdateRunRequestOutputs, object>? outputs = default,
            global::System.OneOf<global::System.Collections.Generic.IList<global::LangSmith.UpdateRunRequestEventsVariant1Item>, object>? events = default,
            global::System.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::System.OneOf<global::LangSmith.UpdateRunRequestExtra, object>? extra = default,
            global::System.OneOf<global::LangSmith.UpdateRunRequestInputAttachments, object>? inputAttachments = default,
            global::System.OneOf<global::LangSmith.UpdateRunRequestOutputAttachments, object>? outputAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.UpdateRunRequest
            {
                TraceId = traceId,
                DottedOrder = dottedOrder,
                ParentRunId = parentRunId,
                EndTime = endTime,
                Error = error,
                Inputs = inputs,
                Outputs = outputs,
                Events = events,
                Tags = tags,
                Extra = extra,
                InputAttachments = inputAttachments,
                OutputAttachments = outputAttachments,
            };

            return await UpdateRunApiV1RunsRunIdPatchAsync(
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}