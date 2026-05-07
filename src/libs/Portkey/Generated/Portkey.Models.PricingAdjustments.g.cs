
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Per-Integration pricing adjustments applied on top of Portkey's base model pricing<br/>
    /// for cost tracking, analytics, and budget limits. Use to reflect negotiated discounts,<br/>
    /// committed-use rates, or internal markups for cost showback.<br/>
    /// Example: {"multiplier":{"default":0.8,"cache_read_input_token":0.9,"cache_write_input_token":0.9}}
    /// </summary>
    public sealed partial class PricingAdjustments
    {
        /// <summary>
        /// Multipliers applied to the corresponding pricing keys from<br/>
        /// [Portkey Models](https://portkey.ai/models). A multiplier of `1` leaves pricing<br/>
        /// unchanged, `0.8` applies a 20% discount, `1.2` applies a 20% markup. Missing or<br/>
        /// `null` fields inherit from `default`; if `default` is also unset, no change is applied.<br/>
        /// All values must be non-negative numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiplier")]
        public global::Portkey.PricingMultiplier? Multiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingAdjustments" /> class.
        /// </summary>
        /// <param name="multiplier">
        /// Multipliers applied to the corresponding pricing keys from<br/>
        /// [Portkey Models](https://portkey.ai/models). A multiplier of `1` leaves pricing<br/>
        /// unchanged, `0.8` applies a 20% discount, `1.2` applies a 20% markup. Missing or<br/>
        /// `null` fields inherit from `default`; if `default` is also unset, no change is applied.<br/>
        /// All values must be non-negative numbers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingAdjustments(
            global::Portkey.PricingMultiplier? multiplier)
        {
            this.Multiplier = multiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingAdjustments" /> class.
        /// </summary>
        public PricingAdjustments()
        {
        }
    }
}