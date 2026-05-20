#nullable enable

namespace Portkey
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create new feedback<br/>
        /// This endpoint allows users to submit feedback for a particular interaction or response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.FeedbackResponse> CreateFeedbackAsync(

            global::Portkey.FeedbackRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new feedback<br/>
        /// This endpoint allows users to submit feedback for a particular interaction or response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.FeedbackResponse>> CreateFeedbackAsResponseAsync(

            global::Portkey.FeedbackRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new feedback<br/>
        /// This endpoint allows users to submit feedback for a particular interaction or response.
        /// </summary>
        /// <param name="traceId">
        /// Unique identifier for the request trace.
        /// </param>
        /// <param name="value">
        /// Feedback value, an integer between -10 and 10.
        /// </param>
        /// <param name="weight">
        /// Weight of the feedback, a float between 0 and 1. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the feedback.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.FeedbackResponse> CreateFeedbackAsync(
            string traceId,
            int value,
            float? weight = default,
            object? metadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}