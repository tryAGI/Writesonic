#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// AI Article Intros<br/>
        /// Generate compelling introductions for a blog article.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> BlogIntrosAsync(
            global::Writesonic.BlogIntrosEngine engine,
            global::Writesonic.BlogIntrosLanguage language,
            int numCopies,

            global::Writesonic.BlogIntrosRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Article Intros<br/>
        /// Generate compelling introductions for a blog article.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="blogTitle">
        /// Title of the blog article to generate an introduction for.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> BlogIntrosAsync(
            global::Writesonic.BlogIntrosEngine engine,
            global::Writesonic.BlogIntrosLanguage language,
            int numCopies,
            string blogTitle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}