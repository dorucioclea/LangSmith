
#nullable enable

namespace LangSmith
{
    public partial class ModelPriceMapClient
    {
        partial void PrepareUpdateModelPriceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            global::LangSmith.ModelPriceMapUpdateSchema request);
        partial void PrepareUpdateModelPriceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::LangSmith.ModelPriceMapUpdateSchema request);
        partial void ProcessUpdateModelPriceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateModelPriceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Model Price
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateModelPriceApiV1ModelPriceMapIdPutResponse> UpdateModelPriceAsync(
            global::System.Guid id,
            global::LangSmith.ModelPriceMapUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateModelPriceArguments(
                httpClient: _httpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/model-price-map/{id}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareUpdateModelPriceRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateModelPriceResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateModelPriceResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.UpdateModelPriceApiV1ModelPriceMapIdPutResponse), JsonSerializerContext) as global::LangSmith.UpdateModelPriceApiV1ModelPriceMapIdPutResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Model Price
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="matchPath">
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="matchPattern"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateModelPriceApiV1ModelPriceMapIdPutResponse> UpdateModelPriceAsync(
            global::System.Guid id,
            string name,
            string matchPattern,
            global::LangSmith.AnyOf<double?, string> promptCost,
            global::LangSmith.AnyOf<double?, string> completionCost,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::System.Collections.Generic.IList<string>? matchPath = default,
            global::LangSmith.AnyOf<string, object>? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ModelPriceMapUpdateSchema
            {
                Name = name,
                StartTime = startTime,
                MatchPath = matchPath,
                MatchPattern = matchPattern,
                PromptCost = promptCost,
                CompletionCost = completionCost,
                Provider = provider,
            };

            return await UpdateModelPriceAsync(
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}