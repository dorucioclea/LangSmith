#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset Run<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="shareToken"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunPublicDatasetSchema> ReadSharedDatasetRunAsync(
            global::System.Guid runId,
            global::System.Guid shareToken,
            bool? excludeS3StoredAttributes = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}