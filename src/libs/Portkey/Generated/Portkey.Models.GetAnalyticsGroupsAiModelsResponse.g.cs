
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsAiModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter))]
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject Object { get; set; }

        /// <summary>
        /// Total records present across all pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsAiModelsResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total records present across all pages
        /// </param>
        /// <param name="data"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGroupsAiModelsResponse(
            int total,
            global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem> data,
            global::Portkey.GetAnalyticsGroupsAiModelsResponseObject @object)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsAiModelsResponse" /> class.
        /// </summary>
        public GetAnalyticsGroupsAiModelsResponse()
        {
        }

    }
}