#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Message Json Schema
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetMessageJsonSchemaAsync(
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}