
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tagKeyId,
            global::LangSmith.TagKeyUpdate request);
        partial void PrepareUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tagKeyId,
            global::LangSmith.TagKeyUpdate request);
        partial void ProcessUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TagKey> UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchAsync(
            string tagKeyId,
            global::LangSmith.TagKeyUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchArguments(
                httpClient: _httpClient,
                tagKeyId: ref tagKeyId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/current/tag-keys/{tagKeyId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TagKeyUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tagKeyId: tagKeyId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.TagKey) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TagKey> UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchAsync(
            string tagKeyId,
            global::System.AnyOf<string?, object>? key = default,
            global::System.AnyOf<string?, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TagKeyUpdate
            {
                Key = key,
                Description = description,
            };

            return await UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchAsync(
                tagKeyId: tagKeyId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}