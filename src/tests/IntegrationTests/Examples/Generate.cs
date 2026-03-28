/*
order: 10
title: Virtual Keys
slug: virtual-keys

Manage virtual keys for provider credentials.
*/

namespace Portkey.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListVirtualKeys()
    {
        using var client = GetAuthenticatedClient();

        //// List all virtual keys in your Portkey account.
        //// Virtual keys securely store provider API keys (e.g., OpenAI, Anthropic)
        //// and can be referenced in gateway configs without exposing raw credentials.
        var response = await client.VirtualKeys.GetVirtualKeysAsync(
            currentPage: 1,
            pageSize: 10);

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();

        Console.WriteLine($"Total virtual keys: {response.Total}");

        foreach (var key in response.Data!)
        {
            Console.WriteLine($"  Key: {key.Name} (Slug: {key.Slug})");
        }
    }
}
