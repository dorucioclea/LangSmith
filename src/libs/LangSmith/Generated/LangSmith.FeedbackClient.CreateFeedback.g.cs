
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.FeedbackCreateSchema request);
        partial void PrepareCreateFeedbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.FeedbackCreateSchema request);
        partial void ProcessCreateFeedbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFeedbackResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            global::LangSmith.FeedbackCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFeedbackArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/feedback",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFeedbackRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFeedbackResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFeedbackResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.FeedbackSchema), JsonSerializerContext) as global::LangSmith.FeedbackSchema ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            string key,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? modifiedAt = default,
            global::LangSmith.AnyOf<double?, int?, bool?, object>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string, global::LangSmith.FeedbackCreateSchemaValue, object>? value = default,
            global::LangSmith.AnyOf<string, object>? comment = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackCreateSchemaCorrection, string, object>? correction = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? feedbackGroupId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? comparativeExperimentId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? runId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId = default,
            global::System.Guid? id = default,
            global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource, object>? feedbackSource = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.FeedbackCreateSchema
            {
                CreatedAt = createdAt,
                ModifiedAt = modifiedAt,
                Key = key,
                Score = score,
                Value = value,
                Comment = comment,
                Correction = correction,
                FeedbackGroupId = feedbackGroupId,
                ComparativeExperimentId = comparativeExperimentId,
                RunId = runId,
                SessionId = sessionId,
                Id = id,
                FeedbackSource = feedbackSource,
                FeedbackConfig = feedbackConfig,
            };

            return await CreateFeedbackAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}