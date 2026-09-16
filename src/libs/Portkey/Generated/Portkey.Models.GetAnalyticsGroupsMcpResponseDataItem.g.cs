
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsGroupsMcpResponseDataItem
    {
        /// <summary>
        /// The MCP server for which the data is calculated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Total requests made for this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsMcpResponseDataItemObjectJsonConverter))]
        public global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsMcpResponseDataItem" /> class.
        /// </summary>
        /// <param name="name">
        /// The MCP server for which the data is calculated
        /// </param>
        /// <param name="requests">
        /// Total requests made for this MCP server
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsMcpResponseDataItem(
            string? name,
            int? requests,
            global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject? @object)
        {
            this.Name = name;
            this.Requests = requests;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsMcpResponseDataItem" /> class.
        /// </summary>
        public GetAnalyticsGroupsMcpResponseDataItem()
        {
        }

    }
}