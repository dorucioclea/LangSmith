#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset Version<br/>
        /// Get dataset version by as_of or exact tag.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> GetDatasetVersionAsync(
            global::System.Guid datasetId,
            global::System.DateTime? asOf = default,
            string? tag = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}