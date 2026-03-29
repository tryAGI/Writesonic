#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Product Descriptions<br/>
        /// Generate compelling product descriptions.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ProductDescriptionsAsync(
            global::Writesonic.ProductDescriptionsEngine engine,
            global::Writesonic.ProductDescriptionsLanguage language,
            int numCopies,

            global::Writesonic.ProductDescriptionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Product Descriptions<br/>
        /// Generate compelling product descriptions.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="productName">
        /// Name of the product.
        /// </param>
        /// <param name="productCharacteristics">
        /// Key features and characteristics of the product.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ProductDescriptionsAsync(
            global::Writesonic.ProductDescriptionsEngine engine,
            global::Writesonic.ProductDescriptionsLanguage language,
            int numCopies,
            string productName,
            string productCharacteristics,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}