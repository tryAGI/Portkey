
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsGroupsWorkspacesResponseDataItem
    {
        /// <summary>
        /// The workspace for which the data is calculated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_slug")]
        public string? WorkspaceSlug { get; set; }

        /// <summary>
        /// Total requests made for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Total cost for the requests made for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsWorkspacesResponseDataItemObjectJsonConverter))]
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsWorkspacesResponseDataItem" /> class.
        /// </summary>
        /// <param name="workspaceSlug">
        /// The workspace for which the data is calculated
        /// </param>
        /// <param name="requests">
        /// Total requests made for this workspace
        /// </param>
        /// <param name="cost">
        /// Total cost for the requests made for this workspace
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsWorkspacesResponseDataItem(
            string? workspaceSlug,
            int? requests,
            double? cost,
            global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject? @object)
        {
            this.WorkspaceSlug = workspaceSlug;
            this.Requests = requests;
            this.Cost = cost;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsWorkspacesResponseDataItem" /> class.
        /// </summary>
        public GetAnalyticsGroupsWorkspacesResponseDataItem()
        {
        }

    }
}