#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Google Ads<br/>
        /// Generate Google Ads headlines and descriptions.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> GoogleAdsAsync(
            global::Writesonic.GoogleAdsEngine engine,
            global::Writesonic.GoogleAdsLanguage language,
            int numCopies,

            global::Writesonic.GoogleAdsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Ads<br/>
        /// Generate Google Ads headlines and descriptions.
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
        /// <param name="searchTerm">
        /// Target search term for the ad.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> GoogleAdsAsync(
            global::Writesonic.GoogleAdsEngine engine,
            global::Writesonic.GoogleAdsLanguage language,
            int numCopies,
            string productName,
            string productDescription,
            string? searchTerm = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}