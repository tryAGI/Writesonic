
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArticleWriterV3Request
    {
        /// <summary>
        /// Title of the article to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArticleTitle { get; set; }

        /// <summary>
        /// A paragraph or two to introduce the article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article_intro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArticleIntro { get; set; }

        /// <summary>
        /// Titles of each section of the article, comma or newline separated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article_sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArticleSections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleWriterV3Request" /> class.
        /// </summary>
        /// <param name="articleTitle">
        /// Title of the article to generate.
        /// </param>
        /// <param name="articleIntro">
        /// A paragraph or two to introduce the article.
        /// </param>
        /// <param name="articleSections">
        /// Titles of each section of the article, comma or newline separated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArticleWriterV3Request(
            string articleTitle,
            string articleIntro,
            string articleSections)
        {
            this.ArticleTitle = articleTitle ?? throw new global::System.ArgumentNullException(nameof(articleTitle));
            this.ArticleIntro = articleIntro ?? throw new global::System.ArgumentNullException(nameof(articleIntro));
            this.ArticleSections = articleSections ?? throw new global::System.ArgumentNullException(nameof(articleSections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleWriterV3Request" /> class.
        /// </summary>
        public ArticleWriterV3Request()
        {
        }
    }
}