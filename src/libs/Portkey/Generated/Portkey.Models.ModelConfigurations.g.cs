
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelConfigurations
    {
        /// <summary>
        /// Custom Host URL for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_host")]
        public string? CustomHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfigurations" /> class.
        /// </summary>
        /// <param name="customHost">
        /// Custom Host URL for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelConfigurations(
            string? customHost)
        {
            this.CustomHost = customHost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfigurations" /> class.
        /// </summary>
        public ModelConfigurations()
        {
        }
    }
}