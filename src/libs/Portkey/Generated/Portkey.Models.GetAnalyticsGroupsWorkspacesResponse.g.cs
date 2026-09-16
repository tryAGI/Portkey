
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsGroupsWorkspacesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsWorkspacesResponseObjectJsonConverter))]
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject Object { get; set; }

        /// <summary>
        /// Total records present across all pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Whether the metric retention quota was exceeded for the requested range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_quota_exceeded")]
        public bool? IsQuotaExceeded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsWorkspacesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="total">
        /// Total records present across all pages
        /// </param>
        /// <param name="isQuotaExceeded">
        /// Whether the metric retention quota was exceeded for the requested range
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsWorkspacesResponse(
            global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem> data,
            global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject @object,
            int? total,
            bool? isQuotaExceeded)
        {
            this.Object = @object;
            this.Total = total;
            this.IsQuotaExceeded = isQuotaExceeded;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsWorkspacesResponse" /> class.
        /// </summary>
        public GetAnalyticsGroupsWorkspacesResponse()
        {
        }

    }
}