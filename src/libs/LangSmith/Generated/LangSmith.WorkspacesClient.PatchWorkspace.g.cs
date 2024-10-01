
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PreparePatchWorkspaceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid workspaceId,
            global::LangSmith.WorkspacePatch request);
        partial void PreparePatchWorkspaceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid workspaceId,
            global::LangSmith.WorkspacePatch request);
        partial void ProcessPatchWorkspaceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchWorkspaceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AppSchemasTenant> PatchWorkspaceAsync(
            global::System.Guid workspaceId,
            global::LangSmith.WorkspacePatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchWorkspaceArguments(
                httpClient: _httpClient,
                workspaceId: ref workspaceId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/workspaces/{workspaceId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchWorkspaceRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                workspaceId: workspaceId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPatchWorkspaceResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchWorkspaceResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.AppSchemasTenant), JsonSerializerContext) as global::LangSmith.AppSchemasTenant ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="displayName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AppSchemasTenant> PatchWorkspaceAsync(
            global::System.Guid workspaceId,
            string displayName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.WorkspacePatch
            {
                DisplayName = displayName,
            };

            return await PatchWorkspaceAsync(
                workspaceId: workspaceId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}