/*
order: 30
title: Image Generation
slug: image-generation

Example showing how to generate images with Photosonic.
*/

namespace Writesonic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateImage()
    {
        using var client = GetAuthenticatedClient();

        //// Generate an image from a text description:
        var response = await client.GenerateImageAsync(
            request: new GenerateImageRequest
            {
                Prompt = "A futuristic city skyline at sunset with flying cars",
                NumImages = 1,
                ImageWidth = 512,
                ImageHeight = 512,
            });

        response.Should().NotBeNull();
        response.Images.Should().NotBeNull();
        response.Images!.Count.Should().BeGreaterThan(0);
    }
}
