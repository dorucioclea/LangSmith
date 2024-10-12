#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Group Runs<br/>
        /// Get runs grouped by an expression
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GroupRunsAsync(
            global::LangSmith.RunGroupRequest request,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Group Runs<br/>
        /// Get runs grouped by an expression
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="filter"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GroupRunsAsync(
            global::System.Guid sessionId,
            string? accept = default,
            global::LangSmith.RunGroupBy groupBy = default,
            string? filter = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? offset = 0,
            int? limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}