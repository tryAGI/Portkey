
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentListItemTypeJsonConverter))]
        public global::Portkey.DeploymentListItemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentListItemStatusJsonConverter))]
        public global::Portkey.DeploymentListItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public int? IsDefault { get; set; }

        /// <summary>
        /// Derived from `last_synced_at` — `healthy` within the last 5 minutes, `unknown` if never synced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentListItemConnectionStatusJsonConverter))]
        public global::Portkey.DeploymentListItemConnectionStatus? ConnectionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_resynced_at")]
        public global::System.DateTime? LastResyncedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.DeploymentListItemObjectJsonConverter))]
        public global::Portkey.DeploymentListItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="isDefault"></param>
        /// <param name="connectionStatus">
        /// Derived from `last_synced_at` — `healthy` within the last 5 minutes, `unknown` if never synced.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="lastSyncedAt"></param>
        /// <param name="lastResyncedAt"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentListItem(
            global::System.Guid? id,
            string? name,
            string? slug,
            global::Portkey.DeploymentListItemType? type,
            global::Portkey.DeploymentListItemStatus? status,
            int? isDefault,
            global::Portkey.DeploymentListItemConnectionStatus? connectionStatus,
            string? createdBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::System.DateTime? lastSyncedAt,
            global::System.DateTime? lastResyncedAt,
            global::Portkey.DeploymentListItemObject? @object)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.Type = type;
            this.Status = status;
            this.IsDefault = isDefault;
            this.ConnectionStatus = connectionStatus;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastSyncedAt = lastSyncedAt;
            this.LastResyncedAt = lastResyncedAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentListItem" /> class.
        /// </summary>
        public DeploymentListItem()
        {
        }

    }
}