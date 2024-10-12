#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Count Examples<br/>
        /// Count all examples by query params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="fullTextContains"></param>
        /// <param name="splits"></param>
        /// <param name="dataset"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<int> CountExamplesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<string>? fullTextContains = default,
            global::System.Collections.Generic.IList<string>? splits = default,
            global::System.Guid? dataset = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}