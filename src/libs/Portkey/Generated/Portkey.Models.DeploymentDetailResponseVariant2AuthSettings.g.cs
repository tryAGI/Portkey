
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentDetailResponseVariant2AuthSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_workspaces")]
        public int? AllowAllWorkspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentDetailResponseVariant2AuthSettings" /> class.
        /// </summary>
        /// <param name="allowAllWorkspaces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentDetailResponseVariant2AuthSettings(
            int? allowAllWorkspaces)
        {
            this.AllowAllWorkspaces = allowAllWorkspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentDetailResponseVariant2AuthSettings" /> class.
        /// </summary>
        public DeploymentDetailResponseVariant2AuthSettings()
        {
        }

    }
}