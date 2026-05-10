
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Image generation pricing multipliers.
    /// </summary>
    public sealed partial class PricingMultiplierImage
    {
        /// <summary>
        /// Multiplier applied to image generation pricing across all qualities and sizes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingMultiplierImage" /> class.
        /// </summary>
        /// <param name="default">
        /// Multiplier applied to image generation pricing across all qualities and sizes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingMultiplierImage(
            double? @default)
        {
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingMultiplierImage" /> class.
        /// </summary>
        public PricingMultiplierImage()
        {
        }

    }
}