
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessPolicyMcpServerTarget
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AccessPolicyMcpServerTargetTypeJsonConverter))]
        public global::Portkey.AccessPolicyMcpServerTargetType Type { get; set; }

        /// <summary>
        /// MCP server ID or slug in the workspace. Responses always return the ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerId { get; set; }

        /// <summary>
        /// `ALL` for every tool on the server, or a non-empty list of tool names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AccessPolicyMcpServerTargetTools?, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.OneOf<global::Portkey.AccessPolicyMcpServerTargetTools?, global::System.Collections.Generic.IList<string>> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyMcpServerTarget" /> class.
        /// </summary>
        /// <param name="serverId">
        /// MCP server ID or slug in the workspace. Responses always return the ID.
        /// </param>
        /// <param name="tools">
        /// `ALL` for every tool on the server, or a non-empty list of tool names
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPolicyMcpServerTarget(
            string serverId,
            global::Portkey.OneOf<global::Portkey.AccessPolicyMcpServerTargetTools?, global::System.Collections.Generic.IList<string>> tools,
            global::Portkey.AccessPolicyMcpServerTargetType type)
        {
            this.Type = type;
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyMcpServerTarget" /> class.
        /// </summary>
        public AccessPolicyMcpServerTarget()
        {
        }

    }
}