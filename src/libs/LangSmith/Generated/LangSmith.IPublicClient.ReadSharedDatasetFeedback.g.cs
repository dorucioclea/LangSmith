#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset Feedback<br/>
        /// Get feedback for runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="run"></param>
        /// <param name="key"></param>
        /// <param name="session"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="user"></param>
        /// <param name="hasComment"></param>
        /// <param name="hasScore"></param>
        /// <param name="level">
        /// Enum for feedback levels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>> ReadSharedDatasetFeedbackAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::System.Collections.Generic.IList<global::System.Guid>? session = default,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::LangSmith.FeedbackLevel? level = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}