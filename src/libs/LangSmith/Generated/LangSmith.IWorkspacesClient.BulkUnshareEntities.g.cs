#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Bulk unshare entities by share tokens for the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BulkUnshareEntitiesAsync(
            global::LangSmith.TenantBulkUnshareRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Bulk unshare entities by share tokens for the workspace.
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BulkUnshareEntitiesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? shareTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}