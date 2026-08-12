#nullable enable

namespace Portkey
{
    public partial interface IOcrClient
    {
        /// <summary>
        /// OCR<br/>
        /// Extract text and structured content from documents (PDFs and images) using OCR models. This endpoint provides a unified interface to document processing models from providers including Mistral AI and Azure AI Foundry.<br/>
        /// The response contains extracted markdown content for each page, along with optional base64-encoded images of the pages.
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
        global::System.Threading.Tasks.Task<global::Portkey.CreateOcrResponse> CreateOcrAsync(

            global::Portkey.CreateOcrRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OCR<br/>
        /// Extract text and structured content from documents (PDFs and images) using OCR models. This endpoint provides a unified interface to document processing models from providers including Mistral AI and Azure AI Foundry.<br/>
        /// The response contains extracted markdown content for each page, along with optional base64-encoded images of the pages.
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
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateOcrResponse>> CreateOcrAsResponseAsync(

            global::Portkey.CreateOcrRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OCR<br/>
        /// Extract text and structured content from documents (PDFs and images) using OCR models. This endpoint provides a unified interface to document processing models from providers including Mistral AI and Azure AI Foundry.<br/>
        /// The response contains extracted markdown content for each page, along with optional base64-encoded images of the pages.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="model">
        /// ID of the model to use for OCR processing. Model availability depends on the provider:<br/>
        /// - **Mistral AI**: `mistral-ocr-latest`, `mistral-ocr-4-0`<br/>
        /// - **Azure AI Foundry**: `mistral-ocr-4-0`, `mistral-document-ai-2505`, `mistral-document-ai-2512`<br/>
        /// Example: mistral-ocr-latest
        /// </param>
        /// <param name="document">
        /// The document to process. Specify either a URL or base64-encoded content.
        /// </param>
        /// <param name="includeImageBase64">
        /// Whether to include base64-encoded images of each page in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="imageLimit">
        /// Maximum number of pages to process. If not specified, all pages are processed.
        /// </param>
        /// <param name="imageMinSize">
        /// Minimum size (in pixels) for images to be included in the response.
        /// </param>
        /// <param name="pages">
        /// Specific page numbers to process (0-indexed). If not specified, all pages are processed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateOcrResponse> CreateOcrAsync(
            string model,
            global::Portkey.CreateOcrRequestDocument document,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            bool? includeImageBase64 = default,
            int? imageLimit = default,
            int? imageMinSize = default,
            global::System.Collections.Generic.IList<int>? pages = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}