#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Tone Changer<br/>
        /// Change the tone of content to match a desired style (professional, casual, friendly, etc.).
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ToneChangerAsync(
            global::Writesonic.ToneChangerEngine engine,
            global::Writesonic.ToneChangerLanguage language,
            int numCopies,

            global::Writesonic.ToneChangerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tone Changer<br/>
        /// Change the tone of content to match a desired style (professional, casual, friendly, etc.).
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="content">
        /// The text content whose tone should be changed.
        /// </param>
        /// <param name="tone">
        /// The desired tone (e.g. professional, casual, friendly, witty).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ToneChangerAsync(
            global::Writesonic.ToneChangerEngine engine,
            global::Writesonic.ToneChangerLanguage language,
            int numCopies,
            string content,
            string tone,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}