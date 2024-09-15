#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Customers And Get Stripe Setup Intent
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.StripeSetupIntentResponse> CreateCustomersAndGetStripeSetupIntentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}