
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareListRulesApiV1RunsRulesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<string, object>? datasetId,
            ref global::System.AnyOf<string, object>? sessionId,
            ref global::System.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type,
            ref global::System.AnyOf<string, object>? nameContains);
        partial void PrepareListRulesApiV1RunsRulesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<string, object>? datasetId,
            global::System.AnyOf<string, object>? sessionId,
            global::System.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type,
            global::System.AnyOf<string, object>? nameContains);
        partial void ProcessListRulesApiV1RunsRulesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRulesApiV1RunsRulesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Rules<br/>
        /// List all run rules.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>> ListRulesApiV1RunsRulesGetAsync(
            global::System.AnyOf<string, object>? datasetId = default,
            global::System.AnyOf<string, object>? sessionId = default,
            global::System.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type = default,
            global::System.AnyOf<string, object>? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRulesApiV1RunsRulesGetArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                sessionId: ref sessionId,
                type: ref type,
                nameContains: ref nameContains);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/rules?dataset_id={datasetId}&session_id={sessionId}&type={type}&name_contains={nameContains}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListRulesApiV1RunsRulesGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                sessionId: sessionId,
                type: type,
                nameContains: nameContains);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListRulesApiV1RunsRulesGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRulesApiV1RunsRulesGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListRunRulesSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}