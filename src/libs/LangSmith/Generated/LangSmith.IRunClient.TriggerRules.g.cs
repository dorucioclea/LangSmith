#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Trigger Rules<br/>
        /// Trigger an array of run rules manually.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggerRulesApiV1RunsRulesTriggerPostResponse> TriggerRulesAsync(
            global::LangSmith.TriggerRulesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger Rules<br/>
        /// Trigger an array of run rules manually.
        /// </summary>
        /// <param name="ruleIds"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggerRulesApiV1RunsRulesTriggerPostResponse> TriggerRulesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? ruleIds = default,
            global::System.Guid? datasetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}