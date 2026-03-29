#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Product Names<br/>
        /// Generate creative product names from a description and keywords.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ProductNamesAsync(
            global::Writesonic.ProductNamesEngine engine,
            global::Writesonic.ProductNamesLanguage language,
            int numCopies,

            global::Writesonic.ProductNamesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Product Names<br/>
        /// Generate creative product names from a description and keywords.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="productDescription">
        /// Description of the product to name.
        /// </param>
        /// <param name="keywords">
        /// Keywords to incorporate in the product name.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ProductNamesAsync(
            global::Writesonic.ProductNamesEngine engine,
            global::Writesonic.ProductNamesLanguage language,
            int numCopies,
            string productDescription,
            string? keywords = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}