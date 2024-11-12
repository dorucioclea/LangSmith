#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetDatasetSplitsAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}