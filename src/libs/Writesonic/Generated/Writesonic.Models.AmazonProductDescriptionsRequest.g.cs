
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AmazonProductDescriptionsRequest
    {
        /// <summary>
        /// Name of the Amazon product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// Key features and benefits of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductFeatures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonProductDescriptionsRequest" /> class.
        /// </summary>
        /// <param name="productName">
        /// Name of the Amazon product.
        /// </param>
        /// <param name="productFeatures">
        /// Key features and benefits of the product.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AmazonProductDescriptionsRequest(
            string productName,
            string productFeatures)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.ProductFeatures = productFeatures ?? throw new global::System.ArgumentNullException(nameof(productFeatures));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonProductDescriptionsRequest" /> class.
        /// </summary>
        public AmazonProductDescriptionsRequest()
        {
        }
    }
}