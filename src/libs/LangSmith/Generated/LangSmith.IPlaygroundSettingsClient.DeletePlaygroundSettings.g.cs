#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Delete Playground Settings<br/>
        /// Delete playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse> DeletePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}