#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Tweets<br/>
        /// Generate engaging tweets for a topic.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> TweetsAsync(
            global::Writesonic.TweetsEngine engine,
            global::Writesonic.TweetsLanguage language,
            int numCopies,

            global::Writesonic.TweetsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tweets<br/>
        /// Generate engaging tweets for a topic.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="topic">
        /// Topic for the tweet.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> TweetsAsync(
            global::Writesonic.TweetsEngine engine,
            global::Writesonic.TweetsLanguage language,
            int numCopies,
            string topic,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}