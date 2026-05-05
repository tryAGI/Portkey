#nullable enable

namespace Portkey
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Create log export
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateExportResponse> CreateLogsExportsAsync(

            global::Portkey.CreateLogsExportsRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create log export
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.UpdateExportResponse>> CreateLogsExportsAsResponseAsync(

            global::Portkey.CreateLogsExportsRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create log export
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateExportResponse> CreateLogsExportsAsync(
            global::Portkey.GenerationsFilterSchema filters,
            global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem> requestedData,
            string? workspaceId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}