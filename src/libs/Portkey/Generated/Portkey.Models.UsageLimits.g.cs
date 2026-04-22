
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
    /// </summary>
    public sealed partial class UsageLimits
    {
        /// <summary>
        /// Credit Limit. Used for tracking usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_limit")]
        public int? CreditLimit { get; set; }

        /// <summary>
        /// Type of credit limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter))]
        public global::Portkey.UsageLimitsType? Type { get; set; }

        /// <summary>
        /// Alert Threshold. Used for alerting when usage reaches more than this<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_threshold")]
        public int? AlertThreshold { get; set; }

        /// <summary>
        /// Reset the usage periodically.<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodic_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter))]
        public global::Portkey.UsageLimitsPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Reset the usage counter every N days (1-365). Mutually exclusive with periodic_reset.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodic_reset_days")]
        public int? PeriodicResetDays { get; set; }

        /// <summary>
        /// ISO 8601 datetime for the next scheduled usage reset. Auto-computed from periodic_reset or periodic_reset_days if not provided.<br/>
        /// Example: 2026-05-01T00:00:00Z
        /// </summary>
        /// <example>2026-05-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_usage_reset_at")]
        public global::System.DateTime? NextUsageResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimits" /> class.
        /// </summary>
        /// <param name="creditLimit">
        /// Credit Limit. Used for tracking usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Type of credit limit
        /// </param>
        /// <param name="alertThreshold">
        /// Alert Threshold. Used for alerting when usage reaches more than this<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="periodicReset">
        /// Reset the usage periodically.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="periodicResetDays">
        /// Reset the usage counter every N days (1-365). Mutually exclusive with periodic_reset.<br/>
        /// Example: 30
        /// </param>
        /// <param name="nextUsageResetAt">
        /// ISO 8601 datetime for the next scheduled usage reset. Auto-computed from periodic_reset or periodic_reset_days if not provided.<br/>
        /// Example: 2026-05-01T00:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimits(
            int? creditLimit,
            global::Portkey.UsageLimitsType? type,
            int? alertThreshold,
            global::Portkey.UsageLimitsPeriodicReset? periodicReset,
            int? periodicResetDays,
            global::System.DateTime? nextUsageResetAt)
        {
            this.CreditLimit = creditLimit;
            this.Type = type;
            this.AlertThreshold = alertThreshold;
            this.PeriodicReset = periodicReset;
            this.PeriodicResetDays = periodicResetDays;
            this.NextUsageResetAt = nextUsageResetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimits" /> class.
        /// </summary>
        public UsageLimits()
        {
        }
    }
}