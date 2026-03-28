#nullable enable

namespace Portkey
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Delete collection<br/>
        /// Deletes a collection
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteCollectionsByCollectionIdAsync(
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}