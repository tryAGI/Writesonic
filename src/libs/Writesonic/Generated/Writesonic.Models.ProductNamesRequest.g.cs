
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductNamesRequest
    {
        /// <summary>
        /// Description of the product to name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductDescription { get; set; }

        /// <summary>
        /// Keywords to incorporate in the product name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductNamesRequest" /> class.
        /// </summary>
        /// <param name="productDescription">
        /// Description of the product to name.
        /// </param>
        /// <param name="keywords">
        /// Keywords to incorporate in the product name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductNamesRequest(
            string productDescription,
            string? keywords)
        {
            this.ProductDescription = productDescription ?? throw new global::System.ArgumentNullException(nameof(productDescription));
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductNamesRequest" /> class.
        /// </summary>
        public ProductNamesRequest()
        {
        }
    }
}