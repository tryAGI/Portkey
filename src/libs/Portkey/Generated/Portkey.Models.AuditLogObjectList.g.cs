
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditLogObjectList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Records { get; set; }

        /// <summary>
        /// Total number of records in the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AuditLogObjectListObjectJsonConverter))]
        public global::Portkey.AuditLogObjectListObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogObjectList" /> class.
        /// </summary>
        /// <param name="records"></param>
        /// <param name="total">
        /// Total number of records in the response
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogObjectList(
            global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? records,
            int? total,
            global::Portkey.AuditLogObjectListObject? @object)
        {
            this.Records = records;
            this.Total = total;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogObjectList" /> class.
        /// </summary>
        public AuditLogObjectList()
        {
        }

    }
}