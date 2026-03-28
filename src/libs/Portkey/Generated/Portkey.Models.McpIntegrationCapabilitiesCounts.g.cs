
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilitiesCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_templates")]
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? ResourceTemplates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCounts" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="prompts"></param>
        /// <param name="resources"></param>
        /// <param name="resourceTemplates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpIntegrationCapabilitiesCounts(
            global::Portkey.McpIntegrationCapabilitiesCountsTools? tools,
            global::Portkey.McpIntegrationCapabilitiesCountsPrompts? prompts,
            global::Portkey.McpIntegrationCapabilitiesCountsResources? resources,
            global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? resourceTemplates)
        {
            this.Tools = tools;
            this.Prompts = prompts;
            this.Resources = resources;
            this.ResourceTemplates = resourceTemplates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCounts" /> class.
        /// </summary>
        public McpIntegrationCapabilitiesCounts()
        {
        }
    }
}