#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// List Feedback Configs Endpoint
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>> ListFeedbackConfigsEndpointAsync(
            global::System.Collections.Generic.IList<string>? key = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}