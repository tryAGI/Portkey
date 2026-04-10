#nullable enable

namespace Portkey
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Rotate API Key<br/>
        /// Rotates an existing API key and returns a newly generated key value.<br/>
        /// The previous key remains valid during the transition period and expires at `key_transition_expires_at`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.RotateApiKeyResponse> CreateKeysByIdRotateAsync(
            global::System.Guid id,

            global::Portkey.RotateApiKeyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate API Key<br/>
        /// Rotates an existing API key and returns a newly generated key value.<br/>
        /// The previous key remains valid during the transition period and expires at `key_transition_expires_at`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.RotateApiKeyResponse>> CreateKeysByIdRotateAsResponseAsync(
            global::System.Guid id,

            global::Portkey.RotateApiKeyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate API Key<br/>
        /// Rotates an existing API key and returns a newly generated key value.<br/>
        /// The previous key remains valid during the transition period and expires at `key_transition_expires_at`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keyTransitionPeriodMs">
        /// Optional transition period in milliseconds during which the previous key remains valid.<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.RotateApiKeyResponse> CreateKeysByIdRotateAsync(
            global::System.Guid id,
            int? keyTransitionPeriodMs = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}