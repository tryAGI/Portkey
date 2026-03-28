
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequiredMetadataKeysParameters
    {
        /// <summary>
        /// Metadata keys to check for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MetadataKeys { get; set; }

        /// <summary>
        /// Operator to use for key checking<br/>
        /// Default Value: all
        /// </summary>
        /// <default>global::Portkey.RequiredMetadataKeysParametersOperator.All</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.RequiredMetadataKeysParametersOperator Operator { get; set; } = global::Portkey.RequiredMetadataKeysParametersOperator.All;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredMetadataKeysParameters" /> class.
        /// </summary>
        /// <param name="metadataKeys">
        /// Metadata keys to check for
        /// </param>
        /// <param name="operator">
        /// Operator to use for key checking<br/>
        /// Default Value: all
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequiredMetadataKeysParameters(
            global::System.Collections.Generic.IList<string> metadataKeys,
            global::Portkey.RequiredMetadataKeysParametersOperator @operator)
        {
            this.MetadataKeys = metadataKeys ?? throw new global::System.ArgumentNullException(nameof(metadataKeys));
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredMetadataKeysParameters" /> class.
        /// </summary>
        public RequiredMetadataKeysParameters()
        {
        }
    }
}