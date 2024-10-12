#nullable enable

namespace LangSmith
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// Create Tenant<br/>
        /// Create a new organization and corresponding workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AppSchemasTenant> CreateTenantAsync(
            global::LangSmith.TenantCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tenant<br/>
        /// Create a new organization and corresponding workspace.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="displayName"></param>
        /// <param name="tenantHandle"></param>
        /// <param name="isPersonal">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AppSchemasTenant> CreateTenantAsync(
            string displayName,
            global::System.Guid? id = default,
            global::System.Guid? organizationId = default,
            string? tenantHandle = default,
            bool? isPersonal = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}