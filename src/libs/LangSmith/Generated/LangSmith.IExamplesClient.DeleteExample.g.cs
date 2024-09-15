#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Delete Example<br/>
        /// Delete a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteExampleApiV1ExamplesExampleIdDeleteResponse> DeleteExampleAsync(
            global::System.Guid exampleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}