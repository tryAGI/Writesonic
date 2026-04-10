#nullable enable

namespace Writesonic
{
    public partial interface IWritesonicClient
    {
        /// <summary>
        /// Generate Image<br/>
        /// Generate images from text descriptions using Photosonic AI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writesonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Writesonic.GenerateImageResponse> GenerateImageAsync(

            global::Writesonic.GenerateImageRequest request,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Image<br/>
        /// Generate images from text descriptions using Photosonic AI.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Writesonic.GenerateImageResponse> GenerateImageAsync(
            string prompt,
            int? numImages = default,
            int? imageWidth = default,
            int? imageHeight = default,
            global::Writesonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}