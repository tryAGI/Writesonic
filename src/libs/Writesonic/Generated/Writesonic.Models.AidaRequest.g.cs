
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AidaRequest
    {
        /// <summary>
        /// Name of the product or service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// Description of the product or service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AidaRequest" /> class.
        /// </summary>
        /// <param name="productName">
        /// Name of the product or service.
        /// </param>
        /// <param name="productDescription">
        /// Description of the product or service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AidaRequest(
            string productName,
            string productDescription)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.ProductDescription = productDescription ?? throw new global::System.ArgumentNullException(nameof(productDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AidaRequest" /> class.
        /// </summary>
        public AidaRequest()
        {
        }
    }
}