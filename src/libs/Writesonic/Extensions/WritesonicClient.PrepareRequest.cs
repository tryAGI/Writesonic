#pragma warning disable CA1822 // Mark members as static
#nullable enable

namespace Writesonic;

public partial class WritesonicClient
{
    // Writesonic uses "X-API-KEY" header instead of "Authorization: Bearer <key>".
    // The generated code sends "Authorization: Bearer <key>" but Writesonic
    // expects the API key in the "X-API-KEY" header without any scheme prefix.
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { Length: > 0 } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("X-API-KEY", apiKey);
        }
    }
}
