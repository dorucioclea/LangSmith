#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset Tracer Sessions<br/>
        /// Get projects run on a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="accept"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>> ReadSharedDatasetTracerSessionsAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::LangSmith.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = default,
            string? sortByFeedbackKey = default,
            int? offset = default,
            int? limit = default,
            bool? facets = default,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}