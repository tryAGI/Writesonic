/*
order: 10
title: ChatSonic
slug: chatsonic

Basic example showing how to use the ChatSonic conversational AI chatbot.
*/

namespace Writesonic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatSonic()
    {
        using var client = GetAuthenticatedClient();

        //// Send a question to ChatSonic with Google search integration:
        var response = await client.ChatSonicAsync(
            engine: ChatSonicEngine.Premium,
            language: ChatSonicLanguage.En,
            numCopies: 1,
            request: new ChatSonicRequest
            {
                InputText = "What is Writesonic?",
                EnableGoogleResults = true,
                EnableMemory = false,
            });

        response.Should().NotBeNull();
        response.Message.Should().NotBeNullOrWhiteSpace();
    }
}
