
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Maps a JWT `sub` to a workspace slug. Subs and workspaces here are merged into the allowed lists.
    /// </summary>
    public sealed partial class DeploymentAuthSettingsInputJwtSubWorkspaceMapping
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}