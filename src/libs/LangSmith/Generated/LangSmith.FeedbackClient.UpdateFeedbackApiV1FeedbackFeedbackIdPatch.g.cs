
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareUpdateFeedbackApiV1FeedbackFeedbackIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string feedbackId,
            global::LangSmith.FeedbackUpdateSchema request);
        partial void PrepareUpdateFeedbackApiV1FeedbackFeedbackIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string feedbackId,
            global::LangSmith.FeedbackUpdateSchema request);
        partial void ProcessUpdateFeedbackApiV1FeedbackFeedbackIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateFeedbackApiV1FeedbackFeedbackIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Feedback<br/>
        /// Replace an existing feedback entry with a new, modified entry.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> UpdateFeedbackApiV1FeedbackFeedbackIdPatchAsync(
            string feedbackId,
            global::LangSmith.FeedbackUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateFeedbackApiV1FeedbackFeedbackIdPatchArguments(
                httpClient: _httpClient,
                feedbackId: ref feedbackId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback/{feedbackId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.FeedbackUpdateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateFeedbackApiV1FeedbackFeedbackIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                feedbackId: feedbackId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateFeedbackApiV1FeedbackFeedbackIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateFeedbackApiV1FeedbackFeedbackIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.FeedbackSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Feedback<br/>
        /// Replace an existing feedback entry with a new, modified entry.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> UpdateFeedbackApiV1FeedbackFeedbackIdPatchAsync(
            string feedbackId,
            global::System.AnyOf<double?, int?, bool?, object>? score = default,
            global::System.AnyOf<double?, int?, bool?, string?, global::LangSmith.FeedbackUpdateSchemaValue, object>? value = default,
            global::System.AnyOf<string?, object>? comment = default,
            global::System.AnyOf<global::LangSmith.FeedbackUpdateSchemaCorrection, string?, object>? correction = default,
            global::System.AnyOf<global::LangSmith.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.FeedbackUpdateSchema
            {
                Score = score,
                Value = value,
                Comment = comment,
                Correction = correction,
                FeedbackConfig = feedbackConfig,
            };

            return await UpdateFeedbackApiV1FeedbackFeedbackIdPatchAsync(
                feedbackId: feedbackId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}