#nullable enable

namespace Portkey
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get a specific log
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.LogObject> GetLogsByLogIdAsync(
            string logId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}