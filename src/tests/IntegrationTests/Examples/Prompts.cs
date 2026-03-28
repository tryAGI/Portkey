/*
order: 30
title: Prompts
slug: prompts

Manage prompt templates for structured LLM interactions.
*/

namespace Portkey.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListPrompts()
    {
        using var client = GetAuthenticatedClient();

        //// List all prompt templates in your Portkey account.
        //// Prompts are reusable templates with variables that can be
        //// rendered and completed through the Portkey gateway.
        var response = await client.Prompts.ListPromptsAsync(
            currentPage: 1,
            pageSize: 10);

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();

        Console.WriteLine($"Total prompts: {response.Total}");

        foreach (var prompt in response.Data!)
        {
            Console.WriteLine($"  Prompt: {prompt.Name} (ID: {prompt.Id})");
        }
    }
}
