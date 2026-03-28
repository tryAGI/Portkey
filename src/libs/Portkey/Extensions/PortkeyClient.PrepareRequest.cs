namespace Portkey;

public partial class PortkeyClient
{
    /// <summary>
    /// Converts the generated "Authorization: Bearer {key}" header
    /// to the Portkey-native "x-portkey-api-key: {key}" header.
    /// </summary>
#pragma warning disable CA1822 // Member does not access instance data
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { Length: > 0 } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("x-portkey-api-key", apiKey);
        }
    }
}
