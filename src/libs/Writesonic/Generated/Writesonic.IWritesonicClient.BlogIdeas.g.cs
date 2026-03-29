#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// AI Article Ideas<br/>
        /// Generate creative blog article ideas for a given topic.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> BlogIdeasAsync(
            global::Writesonic.BlogIdeasEngine engine,
            global::Writesonic.BlogIdeasLanguage language,
            int numCopies,

            global::Writesonic.BlogIdeasRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Article Ideas<br/>
        /// Generate creative blog article ideas for a given topic.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="topic">
        /// Topic to generate blog article ideas for.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> BlogIdeasAsync(
            global::Writesonic.BlogIdeasEngine engine,
            global::Writesonic.BlogIdeasLanguage language,
            int numCopies,
            string topic,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}