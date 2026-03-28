namespace Portkey.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PortkeyClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PORTKEY_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PORTKEY_API_KEY environment variable is not found.");

        var client = new PortkeyClient(apiKey);
        
        return client;
    }
}
