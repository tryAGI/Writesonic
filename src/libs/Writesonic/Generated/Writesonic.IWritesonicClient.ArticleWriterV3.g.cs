#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// AI Article Writer 3.0<br/>
        /// Generate a full-length SEO-optimized article (~1500 words) from a title, intro, and section titles.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ArticleWriterV3Async(
            global::Writesonic.ArticleWriterV3Engine engine,
            global::Writesonic.ArticleWriterV3Language language,
            int numCopies,

            global::Writesonic.ArticleWriterV3Request request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Article Writer 3.0<br/>
        /// Generate a full-length SEO-optimized article (~1500 words) from a title, intro, and section titles.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="articleTitle">
        /// Title of the article to generate.
        /// </param>
        /// <param name="articleIntro">
        /// A paragraph or two to introduce the article.
        /// </param>
        /// <param name="articleSections">
        /// Titles of each section of the article, comma or newline separated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> ArticleWriterV3Async(
            global::Writesonic.ArticleWriterV3Engine engine,
            global::Writesonic.ArticleWriterV3Language language,
            int numCopies,
            string articleTitle,
            string articleIntro,
            string articleSections,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}