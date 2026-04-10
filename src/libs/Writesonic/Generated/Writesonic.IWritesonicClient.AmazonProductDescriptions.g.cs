#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Amazon Product Descriptions<br/>
        /// Generate optimized Amazon product descriptions.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> AmazonProductDescriptionsAsync(
            global::Writesonic.AmazonProductDescriptionsEngine engine,
            global::Writesonic.AmazonProductDescriptionsLanguage language,
            int numCopies,

            global::Writesonic.AmazonProductDescriptionsRequest request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Amazon Product Descriptions<br/>
        /// Generate optimized Amazon product descriptions.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="productName">
        /// Name of the Amazon product.
        /// </param>
        /// <param name="productFeatures">
        /// Key features and benefits of the product.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> AmazonProductDescriptionsAsync(
            global::Writesonic.AmazonProductDescriptionsEngine engine,
            global::Writesonic.AmazonProductDescriptionsLanguage language,
            int numCopies,
            string productName,
            string productFeatures,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}