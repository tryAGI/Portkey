
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: {"email":"test@john.doe","role":"admin","workspaces":[{"id":"ws-slug","role":"member"}]}
    /// </summary>
    public sealed partial class CreateInvite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite> Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.InviteRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.InviteRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_api_key_details")]
        public global::Portkey.CreateInviteWorkspaceApiKeyDetails? WorkspaceApiKeyDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvite" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="workspaces"></param>
        /// <param name="role"></param>
        /// <param name="workspaceApiKeyDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInvite(
            string email,
            global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite> workspaces,
            global::Portkey.InviteRole role,
            global::Portkey.CreateInviteWorkspaceApiKeyDetails? workspaceApiKeyDetails)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
            this.Role = role;
            this.WorkspaceApiKeyDetails = workspaceApiKeyDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvite" /> class.
        /// </summary>
        public CreateInvite()
        {
        }
    }
}