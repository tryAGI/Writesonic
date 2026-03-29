
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SeoMetaTagsRequest
    {
        /// <summary>
        /// Title of the page for SEO meta tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageTitle { get; set; }

        /// <summary>
        /// Brief description of the page content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageDescription { get; set; }

        /// <summary>
        /// Target search term or keyword.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_term")]
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeoMetaTagsRequest" /> class.
        /// </summary>
        /// <param name="pageTitle">
        /// Title of the page for SEO meta tags.
        /// </param>
        /// <param name="pageDescription">
        /// Brief description of the page content.
        /// </param>
        /// <param name="searchTerm">
        /// Target search term or keyword.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeoMetaTagsRequest(
            string pageTitle,
            string pageDescription,
            string? searchTerm)
        {
            this.PageTitle = pageTitle ?? throw new global::System.ArgumentNullException(nameof(pageTitle));
            this.PageDescription = pageDescription ?? throw new global::System.ArgumentNullException(nameof(pageDescription));
            this.SearchTerm = searchTerm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeoMetaTagsRequest" /> class.
        /// </summary>
        public SeoMetaTagsRequest()
        {
        }
    }
}