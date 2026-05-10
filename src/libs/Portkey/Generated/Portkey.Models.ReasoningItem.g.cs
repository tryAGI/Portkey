
#nullable enable

namespace Portkey
{
    /// <summary>
    /// A description of the chain of thought used by a reasoning model while generating<br/>
    /// a response.
    /// </summary>
    public sealed partial class ReasoningItem
    {
        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter))]
        public global::Portkey.ReasoningItemType Type { get; set; }

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Reasoning text contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem> Summary { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter))]
        public global::Portkey.ReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="summary">
        /// Reasoning text contents.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem> summary,
            global::Portkey.ReasoningItemType type,
            global::Portkey.ReasoningItemStatus? status)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        public ReasoningItem()
        {
        }

    }
}