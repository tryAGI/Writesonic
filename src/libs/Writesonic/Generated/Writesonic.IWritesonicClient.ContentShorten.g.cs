#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Content Shorten<br/>
        /// Shorten content while preserving key information.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ContentShortenAsync(
            global::Writesonic.ContentShortenEngine engine,
            global::Writesonic.ContentShortenLanguage language,
            int numCopies,

            global::Writesonic.ContentShortenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Content Shorten<br/>
        /// Shorten content while preserving key information.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="contentToShorten">
        /// The text content to shorten.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ContentShortenAsync(
            global::Writesonic.ContentShortenEngine engine,
            global::Writesonic.ContentShortenLanguage language,
            int numCopies,
            string contentToShorten,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}