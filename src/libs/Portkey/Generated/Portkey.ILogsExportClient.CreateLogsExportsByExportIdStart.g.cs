#nullable enable

namespace Portkey
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Start log export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ExportTaskResponse> CreateLogsExportsByExportIdStartAsync(
            string exportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}