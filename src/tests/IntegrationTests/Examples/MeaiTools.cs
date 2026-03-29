/*
order: 40
title: MEAI Tools
slug: meai-tools

Examples showing how to use Writesonic AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Writesonic.IntegrationTests;

public partial class Tests
{
    //// Writesonic provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// content generation, ChatSonic chatbot, image generation, and SEO tools.

    [TestMethod]
    public async Task Meai_AsChatSonicTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for ChatSonic conversation:
        var tool = client.AsChatSonicTool();

        tool.Name.Should().Be("ChatSonic");
        tool.Description.Should().Contain("ChatSonic");
    }

    [TestMethod]
    public async Task Meai_AsGenerateArticleTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for generating full articles:
        var tool = client.AsGenerateArticleTool();

        tool.Name.Should().Be("GenerateArticle");
        tool.Description.Should().Contain("article");
    }

    [TestMethod]
    public async Task Meai_AsRephraseTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for rephrasing content:
        var tool = client.AsRephraseTool();

        tool.Name.Should().Be("RephraseContent");
        tool.Description.Should().Contain("Rephrase");
    }

    [TestMethod]
    public async Task Meai_AsGenerateImageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for AI image generation:
        var tool = client.AsGenerateImageTool();

        tool.Name.Should().Be("GenerateImage");
        tool.Description.Should().Contain("image");
    }

    [TestMethod]
    public async Task Meai_AsSeoMetaTagsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for generating SEO meta tags:
        var tool = client.AsSeoMetaTagsTool();

        tool.Name.Should().Be("GenerateSeoMetaTags");
        tool.Description.Should().Contain("SEO");
    }
}
