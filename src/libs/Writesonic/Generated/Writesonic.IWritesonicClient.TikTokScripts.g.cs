#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// TikTok Video Scripts<br/>
        /// Generate creative TikTok video scripts for a topic.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> TikTokScriptsAsync(
            global::Writesonic.TikTokScriptsEngine engine,
            global::Writesonic.TikTokScriptsLanguage language,
            int numCopies,

            global::Writesonic.TikTokScriptsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// TikTok Video Scripts<br/>
        /// Generate creative TikTok video scripts for a topic.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="topic">
        /// Topic for the TikTok video script.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> TikTokScriptsAsync(
            global::Writesonic.TikTokScriptsEngine engine,
            global::Writesonic.TikTokScriptsLanguage language,
            int numCopies,
            string topic,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}