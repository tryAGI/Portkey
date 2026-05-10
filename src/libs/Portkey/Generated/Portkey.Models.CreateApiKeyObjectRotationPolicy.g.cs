
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Automatic key rotation configuration. Requires either rotation_period or next_rotation_at.
    /// </summary>
    public sealed partial class CreateApiKeyObjectRotationPolicy
    {
        /// <summary>
        /// How often to automatically rotate the key.<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter))]
        public global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod? RotationPeriod { get; set; }

        /// <summary>
        /// Explicit datetime for the next rotation. Mutually exclusive with rotation_period.<br/>
        /// Example: 2026-06-01T00:00:00Z
        /// </summary>
        /// <example>2026-06-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_rotation_at")]
        public global::System.DateTime? NextRotationAt { get; set; }

        /// <summary>
        /// Duration in milliseconds during which the previous key remains valid after rotation. Minimum 30 minutes (1800000). Must be less than the full rotation period.<br/>
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
        /// Initializes a new instance of the <see cref="CreateApiKeyObjectRotationPolicy" /> class.
        /// </summary>
        /// <param name="rotationPeriod">
        /// How often to automatically rotate the key.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="nextRotationAt">
        /// Explicit datetime for the next rotation. Mutually exclusive with rotation_period.<br/>
        /// Example: 2026-06-01T00:00:00Z
        /// </param>
        /// <param name="keyTransitionPeriodMs">
        /// Duration in milliseconds during which the previous key remains valid after rotation. Minimum 30 minutes (1800000). Must be less than the full rotation period.<br/>
        /// Example: 3600000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyObjectRotationPolicy(
            global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod? rotationPeriod,
            global::System.DateTime? nextRotationAt,
            int? keyTransitionPeriodMs)
        {
            this.RotationPeriod = rotationPeriod;
            this.NextRotationAt = nextRotationAt;
            this.KeyTransitionPeriodMs = keyTransitionPeriodMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObjectRotationPolicy" /> class.
        /// </summary>
        public CreateApiKeyObjectRotationPolicy()
        {
        }

    }
}