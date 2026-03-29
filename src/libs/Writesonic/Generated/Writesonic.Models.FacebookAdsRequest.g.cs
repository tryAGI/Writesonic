
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacebookAdsRequest
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
        /// The occasion or context for the ad (e.g. holiday sale, launch).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occasion")]
        public string? Occasion { get; set; }

        /// <summary>
        /// Any promotional offer to include.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion")]
        public string? Promotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookAdsRequest" /> class.
        /// </summary>
        /// <param name="productName">
        /// Name of the product or service.
        /// </param>
        /// <param name="productDescription">
        /// Description of the product or service.
        /// </param>
        /// <param name="occasion">
        /// The occasion or context for the ad (e.g. holiday sale, launch).
        /// </param>
        /// <param name="promotion">
        /// Any promotional offer to include.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacebookAdsRequest(
            string productName,
            string productDescription,
            string? occasion,
            string? promotion)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.ProductDescription = productDescription ?? throw new global::System.ArgumentNullException(nameof(productDescription));
            this.Occasion = occasion;
            this.Promotion = promotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookAdsRequest" /> class.
        /// </summary>
        public FacebookAdsRequest()
        {
        }
    }
}