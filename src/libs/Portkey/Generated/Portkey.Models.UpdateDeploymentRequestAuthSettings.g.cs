
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDeploymentRequestAuthSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_workspaces")]
        public bool? AllowAllWorkspaces { get; set; }

        /// <summary>
        /// Workspace slugs to detach
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_workspaces_allowed")]
        public global::System.Collections.Generic.IList<string>? RemoveWorkspacesAllowed { get; set; }

        /// <summary>
        /// JWT subs to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_subs_allowed")]
        public global::System.Collections.Generic.IList<string>? RemoveSubsAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequestAuthSettings" /> class.
        /// </summary>
        /// <param name="allowAllWorkspaces"></param>
        /// <param name="removeWorkspacesAllowed">
        /// Workspace slugs to detach
        /// </param>
        /// <param name="removeSubsAllowed">
        /// JWT subs to remove
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentRequestAuthSettings(
            bool? allowAllWorkspaces,
            global::System.Collections.Generic.IList<string>? removeWorkspacesAllowed,
            global::System.Collections.Generic.IList<string>? removeSubsAllowed)
        {
            this.AllowAllWorkspaces = allowAllWorkspaces;
            this.RemoveWorkspacesAllowed = removeWorkspacesAllowed;
            this.RemoveSubsAllowed = removeSubsAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequestAuthSettings" /> class.
        /// </summary>
        public UpdateDeploymentRequestAuthSettings()
        {
        }

    }
}