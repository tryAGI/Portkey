
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateUsageLimitsPolicyRequest
    {
        /// <summary>
        /// Policy name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Policy description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Array of conditions that define which requests the policy applies to. If provided, this replaces the existing conditions on the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Conditions { get; set; }

        /// <summary>
        /// Maximum usage allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_threshold")]
        public double? AlertThreshold { get; set; }

        /// <summary>
        /// Reset period. Set to null to remove periodic reset. Cannot be combined with periodic_reset_days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodic_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter))]
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Number of days after which usage resets. Cannot be combined with periodic_reset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodic_reset_days")]
        public int? PeriodicResetDays { get; set; }

        /// <summary>
        /// ISO 8601 timestamp for the next scheduled usage reset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_usage_reset_at")]
        public global::System.DateTime? NextUsageResetAt { get; set; }

        /// <summary>
        /// Reset usage for a specific value key (e.g., API key). This will reset the usage counter for that key to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_usage_for_value")]
        public string? ResetUsageForValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUsageLimitsPolicyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="description">
        /// Policy description
        /// </param>
        /// <param name="conditions">
        /// Array of conditions that define which requests the policy applies to. If provided, this replaces the existing conditions on the policy.
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="alertThreshold">
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </param>
        /// <param name="periodicReset">
        /// Reset period. Set to null to remove periodic reset. Cannot be combined with periodic_reset_days.
        /// </param>
        /// <param name="periodicResetDays">
        /// Number of days after which usage resets. Cannot be combined with periodic_reset.
        /// </param>
        /// <param name="nextUsageResetAt">
        /// ISO 8601 timestamp for the next scheduled usage reset.
        /// </param>
        /// <param name="resetUsageForValue">
        /// Reset usage for a specific value key (e.g., API key). This will reset the usage counter for that key to 0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUsageLimitsPolicyRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Portkey.Condition>? conditions,
            double? creditLimit,
            double? alertThreshold,
            global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? periodicReset,
            int? periodicResetDays,
            global::System.DateTime? nextUsageResetAt,
            string? resetUsageForValue)
        {
            this.Name = name;
            this.Description = description;
            this.Conditions = conditions;
            this.CreditLimit = creditLimit;
            this.AlertThreshold = alertThreshold;
            this.PeriodicReset = periodicReset;
            this.PeriodicResetDays = periodicResetDays;
            this.NextUsageResetAt = nextUsageResetAt;
            this.ResetUsageForValue = resetUsageForValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUsageLimitsPolicyRequest" /> class.
        /// </summary>
        public UpdateUsageLimitsPolicyRequest()
        {
        }

    }
}