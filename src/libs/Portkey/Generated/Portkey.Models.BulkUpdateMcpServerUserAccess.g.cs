
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpServerUserAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_access")]
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? UserAccess { get; set; }

        /// <summary>
        /// Server default when user has no explicit override
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_user_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter))]
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? DefaultUserAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccess" /> class.
        /// </summary>
        /// <param name="userAccess"></param>
        /// <param name="defaultUserAccess">
        /// Server default when user has no explicit override
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateMcpServerUserAccess(
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? userAccess,
            global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? defaultUserAccess)
        {
            this.UserAccess = userAccess;
            this.DefaultUserAccess = defaultUserAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccess" /> class.
        /// </summary>
        public BulkUpdateMcpServerUserAccess()
        {
        }

    }
}