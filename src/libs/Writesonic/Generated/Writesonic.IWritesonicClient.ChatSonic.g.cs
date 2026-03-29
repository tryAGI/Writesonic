#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// ChatSonic (Like ChatGPT)<br/>
        /// Conversational AI chatbot with real-time Google search integration,<br/>
        /// memory functionality, and support for 24 languages.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Writesonic.ChatSonicResponse> ChatSonicAsync(
            global::Writesonic.ChatSonicEngine engine,
            global::Writesonic.ChatSonicLanguage language,
            int numCopies,

            global::Writesonic.ChatSonicRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ChatSonic (Like ChatGPT)<br/>
        /// Conversational AI chatbot with real-time Google search integration,<br/>
        /// memory functionality, and support for 24 languages.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="enableGoogleResults">
        /// When enabled, ChatSonic uses Google search results to answer.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableMemory">
        /// When enabled, ChatSonic remembers previous conversation context.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="inputText">
        /// The question or prompt to send to ChatSonic.
        /// </param>
        /// <param name="historyData">
        /// Previous conversation turns for context when memory is enabled.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Writesonic.ChatSonicResponse> ChatSonicAsync(
            global::Writesonic.ChatSonicEngine engine,
            global::Writesonic.ChatSonicLanguage language,
            int numCopies,
            string inputText,
            bool? enableGoogleResults = default,
            bool? enableMemory = default,
            global::System.Collections.Generic.IList<global::Writesonic.HistoryEntry>? historyData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}