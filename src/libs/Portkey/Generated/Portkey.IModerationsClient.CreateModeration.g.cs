#nullable enable

namespace Portkey
{
    public partial interface IModerationsClient
    {
        /// <summary>
        /// Identify potentially harmful content in text and images. **Only** works with [OpenAI's Moderations endpoint](https://platform.openai.com/docs/guides/moderation) currently.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateModerationResponse> CreateModerationAsync(

            global::Portkey.CreateModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Identify potentially harmful content in text and images. **Only** works with [OpenAI's Moderations endpoint](https://platform.openai.com/docs/guides/moderation) currently.
        /// </summary>
        /// <param name="input">
        /// The input text to classify
        /// </param>
        /// <param name="model">
        /// Two content moderations models are available: `text-moderation-stable` and `text-moderation-latest`.<br/>
        /// The default is `text-moderation-latest` which will be automatically upgraded over time. This ensures you are always using our most accurate model. If you use `text-moderation-stable`, we will provide advanced notice before updating the model. Accuracy of `text-moderation-stable` may be slightly lower than for `text-moderation-latest`.<br/>
        /// Default Value: text-moderation-latest<br/>
        /// Example: text-moderation-stable
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateModerationResponse> CreateModerationAsync(
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}