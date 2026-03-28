#nullable enable

namespace Portkey
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Get collection details<br/>
        /// Retrieves details of a specific collection
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CollectionWithChildCollections> GetCollectionsByCollectionIdAsync(
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}