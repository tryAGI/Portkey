#nullable enable

namespace Portkey
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Update a logs export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateExportResponse> PutLogsExportsByExportIdAsync(
            string exportId,

            global::Portkey.PutLogsExportsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a logs export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateExportResponse> PutLogsExportsByExportIdAsync(
            string exportId,
            global::Portkey.GenerationsFilterSchema filters,
            string? workspaceId = default,
            global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? requestedData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}