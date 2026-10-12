#nullable enable

namespace Portkey
{
    public partial interface IEgressAllowlistClient
    {
        /// <summary>
        /// Create an Egress Allowlist Entry
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateEgressAllowlistEntryResponse> CreateEgressAllowlistEntryAsync(

            global::Portkey.CreateEgressAllowlistRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Egress Allowlist Entry
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateEgressAllowlistEntryResponse>> CreateEgressAllowlistEntryAsResponseAsync(

            global::Portkey.CreateEgressAllowlistRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Egress Allowlist Entry
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Portkey.CreateEgressAllowlistEntryResponse> CreateEgressAllowlistEntryAsync(
            string domain,
            string? description = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}