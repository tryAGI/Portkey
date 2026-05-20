
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: {"role":"member"}
    /// </summary>
    public sealed partial class PutAdminWorkspacesUsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter))]
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesUsersRequest" /> class.
        /// </summary>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAdminWorkspacesUsersRequest(
            global::Portkey.PutAdminWorkspacesUsersRequestRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesUsersRequest" /> class.
        /// </summary>
        public PutAdminWorkspacesUsersRequest()
        {
        }

    }
}