namespace Portkey;

/// <summary>
/// Extension methods for configuring optional Portkey headers.
/// </summary>
public static class PortkeyClientExtensions
{
    /// <summary>
    /// Sets the <c>x-portkey-virtual-key</c> header on the underlying HttpClient.
    /// A virtual key references provider credentials stored in the Portkey vault.
    /// </summary>
    /// <param name="client">The Portkey client.</param>
    /// <param name="virtualKey">The virtual key value.</param>
    /// <returns>The same client for chaining.</returns>
    public static PortkeyClient WithVirtualKey(this PortkeyClient client, string virtualKey)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(virtualKey);

        client.HttpClient.DefaultRequestHeaders.Remove("x-portkey-virtual-key");
        client.HttpClient.DefaultRequestHeaders.Add("x-portkey-virtual-key", virtualKey);
        return client;
    }

    /// <summary>
    /// Sets the <c>x-portkey-config</c> header on the underlying HttpClient.
    /// A config references a gateway configuration stored in Portkey.
    /// </summary>
    /// <param name="client">The Portkey client.</param>
    /// <param name="configId">The config ID or JSON config string.</param>
    /// <returns>The same client for chaining.</returns>
    public static PortkeyClient WithConfig(this PortkeyClient client, string configId)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(configId);

        client.HttpClient.DefaultRequestHeaders.Remove("x-portkey-config");
        client.HttpClient.DefaultRequestHeaders.Add("x-portkey-config", configId);
        return client;
    }

    /// <summary>
    /// Sets the <c>x-portkey-provider</c> header on the underlying HttpClient.
    /// Specifies the AI provider to route the request to.
    /// </summary>
    /// <param name="client">The Portkey client.</param>
    /// <param name="provider">The provider name (e.g., "openai", "anthropic").</param>
    /// <returns>The same client for chaining.</returns>
    public static PortkeyClient WithProvider(this PortkeyClient client, string provider)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(provider);

        client.HttpClient.DefaultRequestHeaders.Remove("x-portkey-provider");
        client.HttpClient.DefaultRequestHeaders.Add("x-portkey-provider", provider);
        return client;
    }

    /// <summary>
    /// Sets the <c>x-portkey-custom-host</c> header on the underlying HttpClient.
    /// Routes requests to a custom/self-hosted provider endpoint.
    /// </summary>
    /// <param name="client">The Portkey client.</param>
    /// <param name="customHost">The custom host URL.</param>
    /// <returns>The same client for chaining.</returns>
    public static PortkeyClient WithCustomHost(this PortkeyClient client, string customHost)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(customHost);

        client.HttpClient.DefaultRequestHeaders.Remove("x-portkey-custom-host");
        client.HttpClient.DefaultRequestHeaders.Add("x-portkey-custom-host", customHost);
        return client;
    }
}
