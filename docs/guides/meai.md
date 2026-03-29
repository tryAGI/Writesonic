# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Writesonic SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Writesonic's ChatSonic chatbot, article generation, content rephrasing, image generation, and SEO meta tag creation.

## Installation

```bash
dotnet add package Writesonic
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsChatSonicTool()` | `ChatSonic` | Send prompts to ChatSonic chatbot with optional Google search integration |
| `AsGenerateArticleTool()` | `GenerateArticle` | Generate full-length SEO-optimized articles (~1500 words) |
| `AsRephraseTool()` | `RephraseContent` | Rephrase content with optional tone of voice adjustment |
| `AsGenerateImageTool()` | `GenerateImage` | Generate images from text via Photosonic AI |
| `AsSeoMetaTagsTool()` | `GenerateSeoMetaTags` | Generate SEO-optimized meta title and description tags |

## Usage

```csharp
using Writesonic;
using Microsoft.Extensions.AI;

var writesonicClient = new WritesonicClient(
    apiKey: Environment.GetEnvironmentVariable("WRITESONIC_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        writesonicClient.AsChatSonicTool(),
        writesonicClient.AsGenerateArticleTool(),
        writesonicClient.AsRephraseTool(),
        writesonicClient.AsGenerateImageTool(),
        writesonicClient.AsSeoMetaTagsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Generate SEO meta tags for a blog post about sustainable energy."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
