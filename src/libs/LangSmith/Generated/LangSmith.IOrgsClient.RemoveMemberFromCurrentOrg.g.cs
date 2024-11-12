#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove Member From Current Org<br/>
        /// Remove a user from the current organization.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveMemberFromCurrentOrgAsync(
            global::System.Guid identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}