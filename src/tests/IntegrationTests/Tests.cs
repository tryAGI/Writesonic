namespace Writesonic.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WritesonicClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WRITESONIC_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WRITESONIC_API_KEY environment variable is not found.");

        var client = new WritesonicClient(apiKey);
        
        return client;
    }
}
