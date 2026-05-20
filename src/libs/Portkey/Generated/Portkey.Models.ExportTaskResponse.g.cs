
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportTaskResponse
    {
        /// <summary>
        /// A message indicating the status of the export task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The type of the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter))]
        public global::Portkey.ExportTaskResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTaskResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// A message indicating the status of the export task
        /// </param>
        /// <param name="object">
        /// The type of the object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportTaskResponse(
            string message,
            global::Portkey.ExportTaskResponseObject @object)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTaskResponse" /> class.
        /// </summary>
        public ExportTaskResponse()
        {
        }

    }
}