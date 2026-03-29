
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlogIntrosRequest
    {
        /// <summary>
        /// Title of the blog article to generate an introduction for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlogTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogIntrosRequest" /> class.
        /// </summary>
        /// <param name="blogTitle">
        /// Title of the blog article to generate an introduction for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlogIntrosRequest(
            string blogTitle)
        {
            this.BlogTitle = blogTitle ?? throw new global::System.ArgumentNullException(nameof(blogTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogIntrosRequest" /> class.
        /// </summary>
        public BlogIntrosRequest()
        {
        }
    }
}