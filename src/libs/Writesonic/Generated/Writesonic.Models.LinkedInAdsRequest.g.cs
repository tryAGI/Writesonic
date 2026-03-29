
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkedInAdsRequest
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
        /// Target audience for the ad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_audience")]
        public string? TargetAudience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedInAdsRequest" /> class.
        /// </summary>
        /// <param name="productName">
        /// Name of the product or service.
        /// </param>
        /// <param name="productDescription">
        /// Description of the product or service.
        /// </param>
        /// <param name="targetAudience">
        /// Target audience for the ad.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkedInAdsRequest(
            string productName,
            string productDescription,
            string? targetAudience)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.ProductDescription = productDescription ?? throw new global::System.ArgumentNullException(nameof(productDescription));
            this.TargetAudience = targetAudience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedInAdsRequest" /> class.
        /// </summary>
        public LinkedInAdsRequest()
        {
        }
    }
}