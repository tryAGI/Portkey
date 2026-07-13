#nullable enable

namespace Portkey
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get a specific log
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="pathFormat">
        /// Default Value: v1
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.LogObject> GetLogsByLogIdAsync(
            string logId,
            global::Portkey.GetLogsPathFormat? pathFormat = default,
            global::System.DateTime? createdAt = default,
            global::Portkey.GetLogsType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a specific log
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="pathFormat">
        /// Default Value: v1
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.LogObject>> GetLogsByLogIdAsResponseAsync(
            string logId,
            global::Portkey.GetLogsPathFormat? pathFormat = default,
            global::System.DateTime? createdAt = default,
            global::Portkey.GetLogsType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}