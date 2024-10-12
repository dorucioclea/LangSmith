#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update Examples<br/>
        /// Update examples in bulk.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateExamplesAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}