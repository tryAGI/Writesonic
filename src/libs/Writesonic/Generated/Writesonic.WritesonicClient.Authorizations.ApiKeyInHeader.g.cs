
#nullable enable

namespace Writesonic
{
    public sealed partial class WritesonicClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Writesonic.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-KEY",
                Value = apiKey,
            });
        }
    }
}