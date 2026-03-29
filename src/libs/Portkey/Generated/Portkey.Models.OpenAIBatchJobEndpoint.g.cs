
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Inference endpoint
    /// </summary>
    public enum OpenAIBatchJobEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Dividev1DividechatDividecompletions,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Dividecompletions,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Divideembeddings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIBatchJobEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIBatchJobEndpoint value)
        {
            return value switch
            {
                OpenAIBatchJobEndpoint.Dividev1DividechatDividecompletions => "/v1/chat/completions",
                OpenAIBatchJobEndpoint.Dividev1Dividecompletions => "/v1/completions",
                OpenAIBatchJobEndpoint.Dividev1Divideembeddings => "/v1/embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIBatchJobEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => OpenAIBatchJobEndpoint.Dividev1DividechatDividecompletions,
                "/v1/completions" => OpenAIBatchJobEndpoint.Dividev1Dividecompletions,
                "/v1/embeddings" => OpenAIBatchJobEndpoint.Dividev1Divideembeddings,
                _ => null,
            };
        }
    }
}