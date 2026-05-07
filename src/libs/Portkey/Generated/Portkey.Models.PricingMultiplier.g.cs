
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Multipliers applied to the corresponding pricing keys from<br/>
    /// [Portkey Models](https://portkey.ai/models). A multiplier of `1` leaves pricing<br/>
    /// unchanged, `0.8` applies a 20% discount, `1.2` applies a 20% markup. Missing or<br/>
    /// `null` fields inherit from `default`; if `default` is also unset, no change is applied.<br/>
    /// All values must be non-negative numbers.
    /// </summary>
    public sealed partial class PricingMultiplier
    {
        /// <summary>
        /// Multiplier applied to every token type unless a more specific multiplier is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// Multiplier for input/request token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_token")]
        public double? RequestToken { get; set; }

        /// <summary>
        /// Multiplier for output/response token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_token")]
        public double? ResponseToken { get; set; }

        /// <summary>
        /// Multiplier for cache-read input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token")]
        public double? CacheReadInputToken { get; set; }

        /// <summary>
        /// Multiplier for cache-write input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_input_token")]
        public double? CacheWriteInputToken { get; set; }

        /// <summary>
        /// Multiplier for cache-read audio input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_audio_input_token")]
        public double? CacheReadAudioInputToken { get; set; }

        /// <summary>
        /// Multiplier for audio input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_audio_token")]
        public double? RequestAudioToken { get; set; }

        /// <summary>
        /// Multiplier for audio output token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_audio_token")]
        public double? ResponseAudioToken { get; set; }

        /// <summary>
        /// Multiplier for reasoning/thinking token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_token")]
        public double? ReasoningToken { get; set; }

        /// <summary>
        /// Multiplier for accepted predicted-output token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_accepted_token")]
        public double? PredictionAcceptedToken { get; set; }

        /// <summary>
        /// Multiplier for rejected predicted-output token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_rejected_token")]
        public double? PredictionRejectedToken { get; set; }

        /// <summary>
        /// Multiplier for image-modality input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_image_token")]
        public double? RequestImageToken { get; set; }

        /// <summary>
        /// Multiplier for image-modality output token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_image_token")]
        public double? ResponseImageToken { get; set; }

        /// <summary>
        /// Multiplier for text-modality input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_text_token")]
        public double? RequestTextToken { get; set; }

        /// <summary>
        /// Multiplier for text-modality output token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_text_token")]
        public double? ResponseTextToken { get; set; }

        /// <summary>
        /// Multiplier for cache-read image-input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_image_input_token")]
        public double? CacheReadImageInputToken { get; set; }

        /// <summary>
        /// Multiplier for cache-read text-input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_text_input_token")]
        public double? CacheReadTextInputToken { get; set; }

        /// <summary>
        /// Multiplier for cache-write text-input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_text_input_token")]
        public double? CacheWriteTextInputToken { get; set; }

        /// <summary>
        /// Multiplier for cache-write image-input token cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_image_input_token")]
        public double? CacheWriteImageInputToken { get; set; }

        /// <summary>
        /// Image generation pricing multipliers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Portkey.PricingMultiplierImage? Image { get; set; }

        /// <summary>
        /// Multipliers for per-unit charges such as `web_search`, `file_search`, `input_image`,<br/>
        /// `input_video_standard`. Keys must match those returned by Portkey Models for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_units")]
        public global::System.Collections.Generic.Dictionary<string, double?>? AdditionalUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingMultiplier" /> class.
        /// </summary>
        /// <param name="default">
        /// Multiplier applied to every token type unless a more specific multiplier is set.
        /// </param>
        /// <param name="requestToken">
        /// Multiplier for input/request token cost.
        /// </param>
        /// <param name="responseToken">
        /// Multiplier for output/response token cost.
        /// </param>
        /// <param name="cacheReadInputToken">
        /// Multiplier for cache-read input token cost.
        /// </param>
        /// <param name="cacheWriteInputToken">
        /// Multiplier for cache-write input token cost.
        /// </param>
        /// <param name="cacheReadAudioInputToken">
        /// Multiplier for cache-read audio input token cost.
        /// </param>
        /// <param name="requestAudioToken">
        /// Multiplier for audio input token cost.
        /// </param>
        /// <param name="responseAudioToken">
        /// Multiplier for audio output token cost.
        /// </param>
        /// <param name="reasoningToken">
        /// Multiplier for reasoning/thinking token cost.
        /// </param>
        /// <param name="predictionAcceptedToken">
        /// Multiplier for accepted predicted-output token cost.
        /// </param>
        /// <param name="predictionRejectedToken">
        /// Multiplier for rejected predicted-output token cost.
        /// </param>
        /// <param name="requestImageToken">
        /// Multiplier for image-modality input token cost.
        /// </param>
        /// <param name="responseImageToken">
        /// Multiplier for image-modality output token cost.
        /// </param>
        /// <param name="requestTextToken">
        /// Multiplier for text-modality input token cost.
        /// </param>
        /// <param name="responseTextToken">
        /// Multiplier for text-modality output token cost.
        /// </param>
        /// <param name="cacheReadImageInputToken">
        /// Multiplier for cache-read image-input token cost.
        /// </param>
        /// <param name="cacheReadTextInputToken">
        /// Multiplier for cache-read text-input token cost.
        /// </param>
        /// <param name="cacheWriteTextInputToken">
        /// Multiplier for cache-write text-input token cost.
        /// </param>
        /// <param name="cacheWriteImageInputToken">
        /// Multiplier for cache-write image-input token cost.
        /// </param>
        /// <param name="image">
        /// Image generation pricing multipliers.
        /// </param>
        /// <param name="additionalUnits">
        /// Multipliers for per-unit charges such as `web_search`, `file_search`, `input_image`,<br/>
        /// `input_video_standard`. Keys must match those returned by Portkey Models for the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingMultiplier(
            double? @default,
            double? requestToken,
            double? responseToken,
            double? cacheReadInputToken,
            double? cacheWriteInputToken,
            double? cacheReadAudioInputToken,
            double? requestAudioToken,
            double? responseAudioToken,
            double? reasoningToken,
            double? predictionAcceptedToken,
            double? predictionRejectedToken,
            double? requestImageToken,
            double? responseImageToken,
            double? requestTextToken,
            double? responseTextToken,
            double? cacheReadImageInputToken,
            double? cacheReadTextInputToken,
            double? cacheWriteTextInputToken,
            double? cacheWriteImageInputToken,
            global::Portkey.PricingMultiplierImage? image,
            global::System.Collections.Generic.Dictionary<string, double?>? additionalUnits)
        {
            this.Default = @default;
            this.RequestToken = requestToken;
            this.ResponseToken = responseToken;
            this.CacheReadInputToken = cacheReadInputToken;
            this.CacheWriteInputToken = cacheWriteInputToken;
            this.CacheReadAudioInputToken = cacheReadAudioInputToken;
            this.RequestAudioToken = requestAudioToken;
            this.ResponseAudioToken = responseAudioToken;
            this.ReasoningToken = reasoningToken;
            this.PredictionAcceptedToken = predictionAcceptedToken;
            this.PredictionRejectedToken = predictionRejectedToken;
            this.RequestImageToken = requestImageToken;
            this.ResponseImageToken = responseImageToken;
            this.RequestTextToken = requestTextToken;
            this.ResponseTextToken = responseTextToken;
            this.CacheReadImageInputToken = cacheReadImageInputToken;
            this.CacheReadTextInputToken = cacheReadTextInputToken;
            this.CacheWriteTextInputToken = cacheWriteTextInputToken;
            this.CacheWriteImageInputToken = cacheWriteImageInputToken;
            this.Image = image;
            this.AdditionalUnits = additionalUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingMultiplier" /> class.
        /// </summary>
        public PricingMultiplier()
        {
        }
    }
}