#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Update Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagKey> UpdateTagKeyAsync(
            global::System.Guid tagKeyId,
            global::LangSmith.TagKeyUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagKey> UpdateTagKeyAsync(
            global::System.Guid tagKeyId,
            string? key = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}