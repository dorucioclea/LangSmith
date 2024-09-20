
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateCurrentOrgMemberArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid identityId,
            global::LangSmith.OrgIdentityPatch request);
        partial void PrepareUpdateCurrentOrgMemberRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid identityId,
            global::LangSmith.OrgIdentityPatch request);
        partial void ProcessUpdateCurrentOrgMemberResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateCurrentOrgMemberResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse> UpdateCurrentOrgMemberAsync(
            global::System.Guid identityId,
            global::LangSmith.OrgIdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateCurrentOrgMemberArguments(
                httpClient: _httpClient,
                identityId: ref identityId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/orgs/current/members/{identityId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateCurrentOrgMemberRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                identityId: identityId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateCurrentOrgMemberResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateCurrentOrgMemberResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse), JsonSerializerContext) as global::LangSmith.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse> UpdateCurrentOrgMemberAsync(
            global::System.Guid identityId,
            global::LangSmith.AnyOf<string, object>? password = default,
            global::LangSmith.AnyOf<string, object>? fullName = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.OrgIdentityPatch
            {
                Password = password,
                FullName = fullName,
                RoleId = roleId,
            };

            return await UpdateCurrentOrgMemberAsync(
                identityId: identityId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}