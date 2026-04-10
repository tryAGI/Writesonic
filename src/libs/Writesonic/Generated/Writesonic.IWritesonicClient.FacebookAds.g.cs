#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Facebook Ads<br/>
        /// Generate compelling Facebook ad copy.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> FacebookAdsAsync(
            global::Writesonic.FacebookAdsEngine engine,
            global::Writesonic.FacebookAdsLanguage language,
            int numCopies,

            global::Writesonic.FacebookAdsRequest request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Facebook Ads<br/>
        /// Generate compelling Facebook ad copy.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="productName">
        /// Name of the product or service.
        /// </param>
        /// <param name="productDescription">
        /// Description of the product or service.
        /// </param>
        /// <param name="occasion">
        /// The occasion or context for the ad (e.g. holiday sale, launch).
        /// </param>
        /// <param name="promotion">
        /// Any promotional offer to include.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> FacebookAdsAsync(
            global::Writesonic.FacebookAdsEngine engine,
            global::Writesonic.FacebookAdsLanguage language,
            int numCopies,
            string productName,
            string productDescription,
            string? occasion = default,
            string? promotion = default,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}