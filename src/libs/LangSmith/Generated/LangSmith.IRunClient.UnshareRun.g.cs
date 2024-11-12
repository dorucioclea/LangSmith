#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Unshare Run<br/>
        /// Unshare a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnshareRunAsync(
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}