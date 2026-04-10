#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Content Rephrase<br/>
        /// Rephrase content while maintaining meaning, optionally with a specific tone.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ContentRephraseAsync(
            global::Writesonic.ContentRephraseEngine engine,
            global::Writesonic.ContentRephraseLanguage language,
            int numCopies,

            global::Writesonic.ContentRephraseRequest request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Content Rephrase<br/>
        /// Rephrase content while maintaining meaning, optionally with a specific tone.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="contentToRephrase">
        /// The text content to rephrase.
        /// </param>
        /// <param name="toneOfVoice">
        /// Desired tone or style for the rephrased output.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ContentRephraseAsync(
            global::Writesonic.ContentRephraseEngine engine,
            global::Writesonic.ContentRephraseLanguage language,
            int numCopies,
            string contentToRephrase,
            string? toneOfVoice = default,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}