
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId);
        partial void PrepareClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId);
        partial void ProcessClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Claim Pending Organization Invite
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Identity> ClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostArguments(
                httpClient: _httpClient,
                organizationId: ref organizationId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/pending/{organizationId}/claim", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                organizationId: organizationId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessClaimPendingOrganizationInviteApiV1OrgsPendingOrganizationIdClaimPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.Identity) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}