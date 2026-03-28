#nullable enable

namespace Portkey
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Cancel log export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ExportTaskResponse> CreateLogsExportsByExportIdCancelAsync(
            string exportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}