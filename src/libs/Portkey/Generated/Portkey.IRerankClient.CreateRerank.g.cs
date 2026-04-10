#nullable enable

namespace Portkey
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Rerank<br/>
        /// Reranks a list of documents based on their relevance to a query. This endpoint provides a unified interface to reranking models from multiple providers including Cohere, Voyage, Jina, Pinecone, Bedrock, and Azure AI.<br/>
        /// Reranking is useful for improving search results by scoring and sorting documents based on semantic relevance to a query, rather than just keyword matching.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateRerankResponse> CreateRerankAsync(

            global::Portkey.CreateRerankRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank<br/>
        /// Reranks a list of documents based on their relevance to a query. This endpoint provides a unified interface to reranking models from multiple providers including Cohere, Voyage, Jina, Pinecone, Bedrock, and Azure AI.<br/>
        /// Reranking is useful for improving search results by scoring and sorting documents based on semantic relevance to a query, rather than just keyword matching.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateRerankResponse> CreateRerankAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<global::Portkey.RerankDocument> documents,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            int? topN = default,
            bool? returnDocuments = default,
            int? maxTokensPerDoc = default,
            double? priority = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            bool? truncation = default,
            object? parameters = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}