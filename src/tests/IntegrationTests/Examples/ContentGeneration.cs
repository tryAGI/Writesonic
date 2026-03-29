/*
order: 20
title: Content Generation
slug: content-generation

Examples showing how to generate blog articles and other content.
*/

namespace Writesonic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_BlogIdeas()
    {
        using var client = GetAuthenticatedClient();

        //// Generate blog article ideas for a topic:
        var response = await client.BlogIdeasAsync(
            engine: BlogIdeasEngine.Premium,
            language: BlogIdeasLanguage.En,
            numCopies: 3,
            request: new BlogIdeasRequest
            {
                Topic = "artificial intelligence in healthcare",
            });

        response.Should().NotBeNull();
        response.Count.Should().BeGreaterThan(0);
        response[0].Text.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task Example_ArticleWriterV3()
    {
        using var client = GetAuthenticatedClient();

        //// Generate a full-length SEO article:
        var response = await client.ArticleWriterV3Async(
            engine: ArticleWriterV3Engine.Premium,
            language: ArticleWriterV3Language.En,
            numCopies: 1,
            request: new ArticleWriterV3Request
            {
                ArticleTitle = "The Future of AI in Healthcare",
                ArticleIntro = "Artificial intelligence is transforming healthcare at an unprecedented pace.",
                ArticleSections = "Current Applications, Benefits for Patients, Challenges and Ethics, Future Outlook",
            });

        response.Should().NotBeNull();
        response.Count.Should().BeGreaterThan(0);
        response[0].Text.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task Example_ContentRephrase()
    {
        using var client = GetAuthenticatedClient();

        //// Rephrase content with a specific tone:
        var response = await client.ContentRephraseAsync(
            engine: ContentRephraseEngine.Premium,
            language: ContentRephraseLanguage.En,
            numCopies: 1,
            request: new ContentRephraseRequest
            {
                ContentToRephrase = "The product has many features that make it useful for various tasks in the workplace.",
                ToneOfVoice = "professional",
            });

        response.Should().NotBeNull();
        response.Count.Should().BeGreaterThan(0);
        response[0].Text.Should().NotBeNullOrWhiteSpace();
    }
}
