
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateApiKeyObjectRateLimit
    {
        /// <summary>
        /// Example: requests
        /// </summary>
        /// <example>requests</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.UpdateApiKeyObjectRateLimitType Type { get; set; }

        /// <summary>
        /// Rate limit unit: requests/tokens per day, hour, minute, second, or week.<br/>
        /// Example: rpm
        /// </summary>
        /// <example>rpm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateApiKeyObjectRateLimitUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.UpdateApiKeyObjectRateLimitUnit Unit { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObjectRateLimit" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: requests
        /// </param>
        /// <param name="unit">
        /// Rate limit unit: requests/tokens per day, hour, minute, second, or week.<br/>
        /// Example: rpm
        /// </param>
        /// <param name="value">
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyObjectRateLimit(
            global::Portkey.UpdateApiKeyObjectRateLimitType type,
            global::Portkey.UpdateApiKeyObjectRateLimitUnit unit,
            int value)
        {
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObjectRateLimit" /> class.
        /// </summary>
        public UpdateApiKeyObjectRateLimit()
        {
        }
    }
}