
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGuardrailRequest
    {
        /// <summary>
        /// Updated name of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated array of guardrail checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Checks { get; set; }

        /// <summary>
        /// Actions to take when guardrail checks fail or pass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::Portkey.GuardrailActions? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name of the guardrail
        /// </param>
        /// <param name="checks">
        /// Updated array of guardrail checks
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGuardrailRequest(
            string? name,
            global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? checks,
            global::Portkey.GuardrailActions? actions)
        {
            this.Name = name;
            this.Checks = checks;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        public UpdateGuardrailRequest()
        {
        }

    }
}