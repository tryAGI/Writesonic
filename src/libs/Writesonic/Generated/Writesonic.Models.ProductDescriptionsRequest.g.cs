
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductDescriptionsRequest
    {
        /// <summary>
        /// Name of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// Key features and characteristics of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_characteristics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductCharacteristics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDescriptionsRequest" /> class.
        /// </summary>
        /// <param name="productName">
        /// Name of the product.
        /// </param>
        /// <param name="productCharacteristics">
        /// Key features and characteristics of the product.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductDescriptionsRequest(
            string productName,
            string productCharacteristics)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.ProductCharacteristics = productCharacteristics ?? throw new global::System.ArgumentNullException(nameof(productCharacteristics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDescriptionsRequest" /> class.
        /// </summary>
        public ProductDescriptionsRequest()
        {
        }
    }
}