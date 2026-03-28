/*
order: 20
title: Configs
slug: configs

Manage gateway configurations for routing and load balancing.
*/

namespace Portkey.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListConfigs()
    {
        using var client = GetAuthenticatedClient();

        //// List all gateway configurations in your Portkey account.
        //// Configs define routing rules, load balancing strategies,
        //// fallbacks, retries, and other gateway behaviors.
        var response = await client.Configs.ListConfigsAsync();

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();

        Console.WriteLine($"Success: {response.Success}");
        Console.WriteLine($"Configs found: {response.Data!.Count}");

        foreach (var config in response.Data)
        {
            Console.WriteLine($"  Config: {config.Name} (Slug: {config.Slug})");
        }
    }
}
