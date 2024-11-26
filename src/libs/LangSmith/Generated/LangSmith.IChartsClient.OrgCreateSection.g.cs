#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Create Section<br/>
        /// Create a new section.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> OrgCreateSectionAsync(
            global::LangSmith.CustomChartsSectionCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Create Section<br/>
        /// Create a new section.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> OrgCreateSectionAsync(
            string title,
            string? description = default,
            int? index = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}