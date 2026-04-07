
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RotateApiKeyRequest
    {
        /// <summary>
        /// Optional transition period in milliseconds during which the previous key remains valid.<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_transition_period_ms")]
        public int? KeyTransitionPeriodMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="keyTransitionPeriodMs">
        /// Optional transition period in milliseconds during which the previous key remains valid.<br/>
        /// Example: 3600000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateApiKeyRequest(
            int? keyTransitionPeriodMs)
        {
            this.KeyTransitionPeriodMs = keyTransitionPeriodMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyRequest" /> class.
        /// </summary>
        public RotateApiKeyRequest()
        {
        }
    }
}