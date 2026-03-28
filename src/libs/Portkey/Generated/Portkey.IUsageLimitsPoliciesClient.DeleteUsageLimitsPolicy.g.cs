#nullable enable

namespace Portkey
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Delete Usage Limits Policy<br/>
        /// Archive (soft delete) a usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}