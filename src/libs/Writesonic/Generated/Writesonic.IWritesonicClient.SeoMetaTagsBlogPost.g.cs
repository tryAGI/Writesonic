#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// SEO Meta Tags (Blog Post)<br/>
        /// Generate SEO meta title and description for a blog post.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> SeoMetaTagsBlogPostAsync(
            global::Writesonic.SeoMetaTagsBlogPostEngine engine,
            global::Writesonic.SeoMetaTagsBlogPostLanguage language,
            int numCopies,

            global::Writesonic.SeoMetaTagsRequest request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SEO Meta Tags (Blog Post)<br/>
        /// Generate SEO meta title and description for a blog post.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="numCopies"></param>
        /// <param name="pageTitle">
        /// Title of the page for SEO meta tags.
        /// </param>
        /// <param name="pageDescription">
        /// Brief description of the page content.
        /// </param>
        /// <param name="searchTerm">
        /// Target search term or keyword.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>> SeoMetaTagsBlogPostAsync(
            global::Writesonic.SeoMetaTagsBlogPostEngine engine,
            global::Writesonic.SeoMetaTagsBlogPostLanguage language,
            int numCopies,
            string pageTitle,
            string pageDescription,
            string? searchTerm = default,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}