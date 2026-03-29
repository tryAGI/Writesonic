
#nullable enable

namespace Writesonic
{
    /// <summary>
    /// Request body for Photosonic image generation.
    /// </summary>
    public sealed partial class GenerateImageRequest
    {
        /// <summary>
        /// Description of the image to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Number of images to generate.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Image width in pixels.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_width")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// Image height in pixels.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_height")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Description of the image to generate.
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="imageWidth">
        /// Image width in pixels.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="imageHeight">
        /// Image height in pixels.<br/>
        /// Default Value: 512
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequest(
            string prompt,
            int? numImages,
            int? imageWidth,
            int? imageHeight)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NumImages = numImages;
            this.ImageWidth = imageWidth;
            this.ImageHeight = imageHeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }
    }
}