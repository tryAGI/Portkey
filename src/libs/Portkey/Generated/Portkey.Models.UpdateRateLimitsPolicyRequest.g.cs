
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRateLimitsPolicyRequest
    {
        /// <summary>
        /// Policy name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Rate unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter))]
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Unit { get; set; }

        /// <summary>
        /// Rate limit value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Array of conditions that define which requests the policy applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRateLimitsPolicyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="unit">
        /// Rate unit
        /// </param>
        /// <param name="value">
        /// Rate limit value
        /// </param>
        /// <param name="conditions">
        /// Array of conditions that define which requests the policy applies to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRateLimitsPolicyRequest(
            string? name,
            global::Portkey.UpdateRateLimitsPolicyRequestUnit? unit,
            double? value,
            global::System.Collections.Generic.IList<global::Portkey.Condition>? conditions)
        {
            this.Name = name;
            this.Unit = unit;
            this.Value = value;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRateLimitsPolicyRequest" /> class.
        /// </summary>
        public UpdateRateLimitsPolicyRequest()
        {
        }

    }
}