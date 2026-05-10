
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Response from the rerank endpoint.
    /// </summary>
    public sealed partial class CreateRerankResponse
    {
        /// <summary>
        /// A unique identifier for the rerank request.<br/>
        /// Example: rerank-abc123
        /// </summary>
        /// <example>rerank-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, which is always "list".<br/>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateRerankResponseObjectJsonConverter))]
        public global::Portkey.CreateRerankResponseObject Object { get; set; }

        /// <summary>
        /// The reranked results sorted by relevance score in descending order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.RerankResult> Results { get; set; }

        /// <summary>
        /// The model used for reranking.<br/>
        /// Example: rerank-v3.5
        /// </summary>
        /// <example>rerank-v3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Usage information for the rerank request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Portkey.RerankUsage? Usage { get; set; }

        /// <summary>
        /// The provider that processed the request.<br/>
        /// Example: cohere
        /// </summary>
        /// <example>cohere</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// The reranked results sorted by relevance score in descending order.
        /// </param>
        /// <param name="model">
        /// The model used for reranking.<br/>
        /// Example: rerank-v3.5
        /// </param>
        /// <param name="id">
        /// A unique identifier for the rerank request.<br/>
        /// Example: rerank-abc123
        /// </param>
        /// <param name="object">
        /// The object type, which is always "list".<br/>
        /// Example: list
        /// </param>
        /// <param name="usage">
        /// Usage information for the rerank request.
        /// </param>
        /// <param name="provider">
        /// The provider that processed the request.<br/>
        /// Example: cohere
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankResponse(
            global::System.Collections.Generic.IList<global::Portkey.RerankResult> results,
            string model,
            string? id,
            global::Portkey.CreateRerankResponseObject @object,
            global::Portkey.RerankUsage? usage,
            string? provider)
        {
            this.Id = id;
            this.Object = @object;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponse" /> class.
        /// </summary>
        public CreateRerankResponse()
        {
        }

    }
}