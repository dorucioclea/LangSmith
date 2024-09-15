#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get Repo<br/>
        /// Get a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetRepoResponse> GetRepoAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}