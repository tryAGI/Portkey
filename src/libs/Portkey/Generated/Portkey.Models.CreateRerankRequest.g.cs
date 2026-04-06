
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Request body for reranking documents. The unified API supports multiple providers including Cohere, Voyage, Jina, Pinecone, Bedrock, and Azure AI.
    /// </summary>
    public sealed partial class CreateRerankRequest
    {
        /// <summary>
        /// ID of the model to use for reranking. Model availability depends on the provider:<br/>
        /// - **Cohere**: `rerank-v3.5`, `rerank-english-v3.0`, `rerank-multilingual-v3.0`, `rerank-english-v2.0`, `rerank-multilingual-v2.0`<br/>
        /// - **Voyage**: `rerank-2`, `rerank-2-lite`<br/>
        /// - **Jina**: `jina-reranker-v2-base-multilingual`, `jina-reranker-v1-base-en`, `jina-reranker-v1-turbo-en`, `jina-reranker-v1-tiny-en`<br/>
        /// - **Pinecone**: `bge-reranker-v2-m3`, `pinecone-rerank-v0`<br/>
        /// - **Bedrock**: Model ARN (e.g., `arn:aws:bedrock:us-west-2::foundation-model/cohere.rerank-v3-5:0`)<br/>
        /// - **Azure AI**: Cohere rerank deployments on Azure AI Inference; use the model name from your deployment, typically prefixed with `cohere.` (the gateway strips that prefix for the upstream request)<br/>
        /// Example: rerank-v3.5
        /// </summary>
        /// <example>rerank-v3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The search query to compare against the documents.<br/>
        /// Example: What is the capital of France?
        /// </summary>
        /// <example>What is the capital of France?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The list of documents to rerank. Each document can be a string or an object with a `text` field.<br/>
        /// The documents will be scored based on their relevance to the query.<br/>
        /// Example: [Paris is the capital of France., Berlin is the capital of Germany., Madrid is the capital of Spain.]
        /// </summary>
        /// <example>[Paris is the capital of France., Berlin is the capital of Germany., Madrid is the capital of Spain.]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.RerankDocument> Documents { get; set; }

        /// <summary>
        /// The number of top results to return. If not specified, all documents are returned sorted by relevance.<br/>
        /// For Voyage, the gateway maps this field to the provider's `top_k` parameter.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Whether to return the document text in the response. Supported by Voyage, Jina, and Pinecone.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// Maximum number of tokens per document. Documents exceeding this limit will be truncated. Cohere-specific parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_per_doc")]
        public int? MaxTokensPerDoc { get; set; }

        /// <summary>
        /// Request priority hint. Cohere-specific parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// The fields to use for ranking when documents are objects with multiple fields. Pinecone-specific parameter.<br/>
        /// Example: [text, title]
        /// </summary>
        /// <example>[text, title]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// Whether to truncate documents that exceed the model's maximum context length. Voyage-specific parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public bool? Truncation { get; set; }

        /// <summary>
        /// Additional provider-specific parameters. Pinecone-specific parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use for reranking. Model availability depends on the provider:<br/>
        /// - **Cohere**: `rerank-v3.5`, `rerank-english-v3.0`, `rerank-multilingual-v3.0`, `rerank-english-v2.0`, `rerank-multilingual-v2.0`<br/>
        /// - **Voyage**: `rerank-2`, `rerank-2-lite`<br/>
        /// - **Jina**: `jina-reranker-v2-base-multilingual`, `jina-reranker-v1-base-en`, `jina-reranker-v1-turbo-en`, `jina-reranker-v1-tiny-en`<br/>
        /// - **Pinecone**: `bge-reranker-v2-m3`, `pinecone-rerank-v0`<br/>
        /// - **Bedrock**: Model ARN (e.g., `arn:aws:bedrock:us-west-2::foundation-model/cohere.rerank-v3-5:0`)<br/>
        /// - **Azure AI**: Cohere rerank deployments on Azure AI Inference; use the model name from your deployment, typically prefixed with `cohere.` (the gateway strips that prefix for the upstream request)<br/>
        /// Example: rerank-v3.5
        /// </param>
        /// <param name="query">
        /// The search query to compare against the documents.<br/>
        /// Example: What is the capital of France?
        /// </param>
        /// <param name="documents">
        /// The list of documents to rerank. Each document can be a string or an object with a `text` field.<br/>
        /// The documents will be scored based on their relevance to the query.<br/>
        /// Example: [Paris is the capital of France., Berlin is the capital of Germany., Madrid is the capital of Spain.]
        /// </param>
        /// <param name="topN">
        /// The number of top results to return. If not specified, all documents are returned sorted by relevance.<br/>
        /// For Voyage, the gateway maps this field to the provider's `top_k` parameter.<br/>
        /// Example: 3
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return the document text in the response. Supported by Voyage, Jina, and Pinecone.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxTokensPerDoc">
        /// Maximum number of tokens per document. Documents exceeding this limit will be truncated. Cohere-specific parameter.
        /// </param>
        /// <param name="priority">
        /// Request priority hint. Cohere-specific parameter.
        /// </param>
        /// <param name="rankFields">
        /// The fields to use for ranking when documents are objects with multiple fields. Pinecone-specific parameter.<br/>
        /// Example: [text, title]
        /// </param>
        /// <param name="truncation">
        /// Whether to truncate documents that exceed the model's maximum context length. Voyage-specific parameter.
        /// </param>
        /// <param name="parameters">
        /// Additional provider-specific parameters. Pinecone-specific parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankRequest(
            string model,
            string query,
            global::System.Collections.Generic.IList<global::Portkey.RerankDocument> documents,
            int? topN,
            bool? returnDocuments,
            int? maxTokensPerDoc,
            double? priority,
            global::System.Collections.Generic.IList<string>? rankFields,
            bool? truncation,
            object? parameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.MaxTokensPerDoc = maxTokensPerDoc;
            this.Priority = priority;
            this.RankFields = rankFields;
            this.Truncation = truncation;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequest" /> class.
        /// </summary>
        public CreateRerankRequest()
        {
        }
    }
}