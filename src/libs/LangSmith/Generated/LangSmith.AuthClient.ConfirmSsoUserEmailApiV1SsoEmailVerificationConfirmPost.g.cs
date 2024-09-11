
#nullable enable

namespace LangSmith
{
    public partial class AuthClient
    {
        partial void PrepareConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.SSOConfirmEmailRequest request);
        partial void PrepareConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.SSOConfirmEmailRequest request);
        partial void ProcessConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Confirm Sso User Email<br/>
        /// Confirm the email of an SSO user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse> ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostAsync(
            global::LangSmith.SSOConfirmEmailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/sso/email-verification/confirm", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.SSOConfirmEmailRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostRequest(
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
            ProcessConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Confirm Sso User Email<br/>
        /// Confirm the email of an SSO user.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse> ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.SSOConfirmEmailRequest
            {
                Token = token,
            };

            return await ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}