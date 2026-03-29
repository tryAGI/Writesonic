#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// AI Article Outlines<br/>
        /// Generate structured outlines for a blog article.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> BlogOutlinesAsync(
            global::Writesonic.BlogOutlinesEngine engine,
            global::Writesonic.BlogOutlinesLanguage language,
            int numCopies,

            global::Writesonic.BlogOutlinesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Article Outlines<br/>
        /// Generate structured outlines for a blog article.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="blogTitle">
        /// Title of the blog article to generate an outline for.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> BlogOutlinesAsync(
            global::Writesonic.BlogOutlinesEngine engine,
            global::Writesonic.BlogOutlinesLanguage language,
            int numCopies,
            string blogTitle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}