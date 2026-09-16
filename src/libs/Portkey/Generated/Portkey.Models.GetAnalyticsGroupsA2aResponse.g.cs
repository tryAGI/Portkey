
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsGroupsA2aResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsA2aResponseObjectJsonConverter))]
        public global::Portkey.GetAnalyticsGroupsA2aResponseObject Object { get; set; }

        /// <summary>
        /// Total records present across all pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsA2aResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="total">
        /// Total records present across all pages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsA2aResponse(
            global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem> data,
            global::Portkey.GetAnalyticsGroupsA2aResponseObject @object,
            int? total)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsA2aResponse" /> class.
        /// </summary>
        public GetAnalyticsGroupsA2aResponse()
        {
        }

    }
}