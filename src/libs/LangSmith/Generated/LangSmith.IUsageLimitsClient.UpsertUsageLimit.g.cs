#nullable enable

namespace LangSmith
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// Upsert Usage Limit<br/>
        /// Create a new usage limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageLimit> UpsertUsageLimitAsync(
            global::LangSmith.UpsertUsageLimit request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upsert Usage Limit<br/>
        /// Create a new usage limit.
        /// </summary>
        /// <param name="limitType">
        /// Type of usage limit.
        /// </param>
        /// <param name="limitValue"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageLimit> UpsertUsageLimitAsync(
            global::LangSmith.UsageLimitType2 limitType,
            int limitValue,
            global::System.Guid id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}