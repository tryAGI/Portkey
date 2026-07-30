
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Custom Headers for the model.
    /// </summary>
    public sealed partial class ModelConfigurationsCustomHeaders
    {
        /// <summary>
        /// Header key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Header value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfigurationsCustomHeaders" /> class.
        /// </summary>
        /// <param name="key">
        /// Header key
        /// </param>
        /// <param name="value">
        /// Header value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelConfigurationsCustomHeaders(
            string? key,
            string? value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfigurationsCustomHeaders" /> class.
        /// </summary>
        public ModelConfigurationsCustomHeaders()
        {
        }

    }
}