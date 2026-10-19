
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema for the tool input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Portkey.AnthropicToolCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputSchema">
        /// JSON Schema for the tool input.
        /// </param>
        /// <param name="description"></param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTool(
            string name,
            object inputSchema,
            string? description,
            global::Portkey.AnthropicToolCacheControl? cacheControl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTool" /> class.
        /// </summary>
        public AnthropicTool()
        {
        }

    }
}