using Microsoft.Extensions.AI;

namespace Writesonic;

/// <summary>
/// Extensions for using WritesonicClient as MEAI tools with any IChatClient.
/// </summary>
public static class WritesonicToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps ChatSonic conversational AI,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Writesonic client to use.</param>
    /// <param name="engine">Quality tier: economy, average, good, or premium.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsChatSonicTool(
        this WritesonicClient client,
        ChatSonicEngine engine = ChatSonicEngine.Premium)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string inputText, bool? enableGoogleResults, CancellationToken cancellationToken) =>
            {
                var response = await client.ChatSonicAsync(
                    engine: engine,
                    language: ChatSonicLanguage.En,
                    numCopies: 1,
                    request: new ChatSonicRequest
                    {
                        InputText = inputText,
                        EnableGoogleResults = enableGoogleResults ?? true,
                        EnableMemory = false,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Message ?? string.Empty;
            },
            name: "ChatSonic",
            description: "Sends a question or prompt to ChatSonic, an AI chatbot with optional real-time Google search integration. Returns the AI-generated response text.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps AI content generation,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Writesonic client to use.</param>
    /// <param name="engine">Quality tier: economy, average, good, or premium.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateArticleTool(
        this WritesonicClient client,
        ArticleWriterV3Engine engine = ArticleWriterV3Engine.Premium)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string articleTitle, string articleIntro, string articleSections, CancellationToken cancellationToken) =>
            {
                var response = await client.ArticleWriterV3Async(
                    engine: engine,
                    language: ArticleWriterV3Language.En,
                    numCopies: 1,
                    request: new ArticleWriterV3Request
                    {
                        ArticleTitle = articleTitle,
                        ArticleIntro = articleIntro,
                        ArticleSections = articleSections,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatContentOutput(response);
            },
            name: "GenerateArticle",
            description: "Generates a full-length SEO-optimized article (~1500 words) from a title, introduction paragraph, and section titles. Returns the complete article text.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps content rephrasing,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Writesonic client to use.</param>
    /// <param name="engine">Quality tier: economy, average, good, or premium.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRephraseTool(
        this WritesonicClient client,
        ContentRephraseEngine engine = ContentRephraseEngine.Premium)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string content, string? toneOfVoice, CancellationToken cancellationToken) =>
            {
                var response = await client.ContentRephraseAsync(
                    engine: engine,
                    language: ContentRephraseLanguage.En,
                    numCopies: 1,
                    request: new ContentRephraseRequest
                    {
                        ContentToRephrase = content,
                        ToneOfVoice = toneOfVoice,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatContentOutput(response);
            },
            name: "RephraseContent",
            description: "Rephrases content while maintaining its original meaning, optionally adjusting to a specified tone of voice (e.g. professional, casual, friendly). Returns the rephrased text.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Photosonic image generation,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Writesonic client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateImageTool(
        this WritesonicClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, int? numImages, CancellationToken cancellationToken) =>
            {
                var response = await client.GenerateImageAsync(
                    request: new GenerateImageRequest
                    {
                        Prompt = prompt,
                        NumImages = numImages ?? 1,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatImageResponse(response);
            },
            name: "GenerateImage",
            description: "Generates images from a text description using Photosonic AI. Returns URLs of the generated images.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps SEO meta tags generation,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Writesonic client to use.</param>
    /// <param name="engine">Quality tier: economy, average, good, or premium.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSeoMetaTagsTool(
        this WritesonicClient client,
        SeoMetaTagsBlogPostEngine engine = SeoMetaTagsBlogPostEngine.Premium)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string pageTitle, string pageDescription, string? searchTerm, CancellationToken cancellationToken) =>
            {
                var response = await client.SeoMetaTagsBlogPostAsync(
                    engine: engine,
                    language: SeoMetaTagsBlogPostLanguage.En,
                    numCopies: 1,
                    request: new SeoMetaTagsRequest
                    {
                        PageTitle = pageTitle,
                        PageDescription = pageDescription,
                        SearchTerm = searchTerm,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatContentOutput(response);
            },
            name: "GenerateSeoMetaTags",
            description: "Generates SEO-optimized meta title and description tags for a web page. Returns the generated meta tags text.");
    }

    private static string FormatContentOutput(IList<ContentOutput> outputs)
    {
        if (outputs is not { Count: > 0 })
        {
            return "No content generated.";
        }

        if (outputs.Count == 1)
        {
            return outputs[0].Text ?? string.Empty;
        }

        var parts = new List<string>();
        for (var i = 0; i < outputs.Count; i++)
        {
            parts.Add($"--- Variation {i + 1} ---");
            parts.Add(outputs[i].Text ?? string.Empty);
        }

        return string.Join("\n", parts);
    }

    private static string FormatImageResponse(GenerateImageResponse response)
    {
        if (response.Images is not { Count: > 0 })
        {
            return "No images generated.";
        }

        var parts = new List<string> { $"Generated {response.Images.Count} image(s):" };
        foreach (var url in response.Images)
        {
            parts.Add($"- {url}");
        }

        return string.Join("\n", parts);
    }
}
