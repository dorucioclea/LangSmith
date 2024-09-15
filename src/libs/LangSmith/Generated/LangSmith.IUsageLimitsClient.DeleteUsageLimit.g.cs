#nullable enable

namespace LangSmith
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// Delete Usage Limit<br/>
        /// Delete a specific usage limit.
        /// </summary>
        /// <param name="usageLimitId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponse> DeleteUsageLimitAsync(
            global::System.Guid usageLimitId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}