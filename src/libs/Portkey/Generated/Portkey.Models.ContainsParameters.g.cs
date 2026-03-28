
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainsParameters
    {
        /// <summary>
        /// Words or phrases to check for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// Operator to use for word checking<br/>
        /// Default Value: any
        /// </summary>
        /// <default>global::Portkey.ContainsParametersOperator.Any</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ContainsParametersOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.ContainsParametersOperator Operator { get; set; } = global::Portkey.ContainsParametersOperator.Any;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsParameters" /> class.
        /// </summary>
        /// <param name="words">
        /// Words or phrases to check for
        /// </param>
        /// <param name="operator">
        /// Operator to use for word checking<br/>
        /// Default Value: any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainsParameters(
            global::System.Collections.Generic.IList<string> words,
            global::Portkey.ContainsParametersOperator @operator)
        {
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsParameters" /> class.
        /// </summary>
        public ContainsParameters()
        {
        }
    }
}