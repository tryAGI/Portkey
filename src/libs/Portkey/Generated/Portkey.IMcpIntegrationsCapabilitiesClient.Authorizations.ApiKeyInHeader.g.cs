
#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsCapabilitiesClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}