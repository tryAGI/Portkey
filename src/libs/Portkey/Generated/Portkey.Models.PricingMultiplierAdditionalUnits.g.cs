
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Multipliers for per-unit charges such as `web_search`, `file_search`, `input_image`,<br/>
    /// `input_video_standard`. Keys must match those returned by Portkey Models for the provider.
    /// </summary>
    public sealed partial class PricingMultiplierAdditionalUnits
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}