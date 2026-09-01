
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Flat key-value string pairs. Keys must be alphanumeric with underscores<br/>
    /// and hyphens (`^[a-zA-Z0-9_-]+$`). Values are arbitrary strings.<br/>
    /// Setting tags to `null` removes all tags from the deployment.<br/>
    /// Example: {"fw-id":"fw-01234","cloud":"aws","region":"us-west-2"}
    /// </summary>
    public sealed partial class DeploymentTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}