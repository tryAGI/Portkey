
#nullable enable

namespace Portkey
{
    public sealed partial class PortkeyClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Portkey.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "x-portkey-api-key",
                Value = apiKey,
            });
        }
    }
}