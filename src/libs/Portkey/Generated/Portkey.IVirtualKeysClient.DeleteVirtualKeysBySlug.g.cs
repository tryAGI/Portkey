#nullable enable

namespace Portkey
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// Delete a Virtual Key
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVirtualKeysBySlugAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}