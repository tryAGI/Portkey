#nullable enable

namespace Portkey
{
    public partial interface IEgressAllowlistClient
    {
        /// <summary>
        /// Update an Egress Allowlist Entry
        /// </summary>
        /// <param name="egressAllowlistId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateEgressAllowlistEntryAsync(
            global::System.Guid egressAllowlistId,

            global::Portkey.UpdateEgressAllowlistRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Egress Allowlist Entry
        /// </summary>
        /// <param name="egressAllowlistId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> UpdateEgressAllowlistEntryAsResponseAsync(
            global::System.Guid egressAllowlistId,

            global::Portkey.UpdateEgressAllowlistRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Egress Allowlist Entry
        /// </summary>
        /// <param name="egressAllowlistId"></param>
        /// <param name="domain">
        /// An exact hostname, an IP literal (IPv4 or IPv6, optionally bracketed), or a `*.` wildcard.<br/>
        /// No scheme, path, credentials, or port. Stored trimmed and lowercased.<br/>
        /// Cloud-metadata addresses and hostnames are rejected.<br/>
        /// Example: *.internal.example.com
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateEgressAllowlistEntryAsync(
            global::System.Guid egressAllowlistId,
            string? domain = default,
            string? description = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}