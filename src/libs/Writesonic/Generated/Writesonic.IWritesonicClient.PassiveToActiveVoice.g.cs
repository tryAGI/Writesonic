#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Passive to Active Voice<br/>
        /// Convert content from passive voice to active voice for more engaging writing.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> PassiveToActiveVoiceAsync(
            global::Writesonic.PassiveToActiveVoiceEngine engine,
            global::Writesonic.PassiveToActiveVoiceLanguage language,
            int numCopies,

            global::Writesonic.ActiveVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Passive to Active Voice<br/>
        /// Convert content from passive voice to active voice for more engaging writing.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="content">
        /// The text content to convert from passive to active voice.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> PassiveToActiveVoiceAsync(
            global::Writesonic.PassiveToActiveVoiceEngine engine,
            global::Writesonic.PassiveToActiveVoiceLanguage language,
            int numCopies,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}