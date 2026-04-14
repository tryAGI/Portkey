
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerConnectionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected")]
        public bool? Connected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerConnectionItem" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="connected"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerConnectionItem(
            global::System.Guid? userId,
            bool? connected,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt)
        {
            this.UserId = userId;
            this.Connected = connected;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerConnectionItem" /> class.
        /// </summary>
        public McpServerConnectionItem()
        {
        }
    }
}