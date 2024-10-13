
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareGetDashboardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.OrganizationDashboardType type,
            ref global::LangSmith.OrganizationDashboardColorScheme colorScheme);
        partial void PrepareGetDashboardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.OrganizationDashboardType type,
            global::LangSmith.OrganizationDashboardColorScheme colorScheme);
        partial void ProcessGetDashboardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDashboardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <param name="type">
        /// Enum for acceptable types of dashboards.
        /// </param>
        /// <param name="colorScheme">
        /// Enum for acceptable color schemes of dashboards.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.OrganizationDashboardSchema> GetDashboardAsync(
            global::LangSmith.OrganizationDashboardType type,
            global::LangSmith.OrganizationDashboardColorScheme colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDashboardArguments(
                httpClient: _httpClient,
                type: ref type,
                colorScheme: ref colorScheme);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/orgs/current/dashboard",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("type", type.ToValueString()) 
                .AddRequiredParameter("color_scheme", colorScheme.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDashboardRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                type: type,
                colorScheme: colorScheme);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDashboardResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDashboardResponseContent(
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
                global::LangSmith.OrganizationDashboardSchema.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}