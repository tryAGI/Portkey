
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionRequestModel), TypeInfoPropertyName = "CreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>), TypeInfoPropertyName = "OneOfStringIListStringIListInt32IListIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseObject), TypeInfoPropertyName = "CreateCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType), TypeInfoPropertyName = "ChatCompletionMessageContentPartThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType), TypeInfoPropertyName = "ChatCompletionMessageContentPartRedactedThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessage), TypeInfoPropertyName = "ChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestDeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestFunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestSystemMessageRole), TypeInfoPropertyName = "ChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole), TypeInfoPropertyName = "ChatCompletionRequestDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestUserMessageRole), TypeInfoPropertyName = "ChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole), TypeInfoPropertyName = "ChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestToolMessageRole), TypeInfoPropertyName = "ChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole), TypeInfoPropertyName = "ChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionFunctions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionFunctionCallOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolType), TypeInfoPropertyName = "ChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOption), TypeInfoPropertyName = "ChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum), TypeInfoPropertyName = "ChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoiceType), TypeInfoPropertyName = "ChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallType), TypeInfoPropertyName = "ChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentBlock), TypeInfoPropertyName = "ChatCompletionMessageContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessageRole), TypeInfoPropertyName = "ChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestModel), TypeInfoPropertyName = "CreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>), TypeInfoPropertyName = "OneOfResponseFormatTextResponseFormatJsonSchemaResponseFormatJsonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestThinkingType), TypeInfoPropertyName = "CreateChatCompletionRequestThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestFunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestFunctionCall), TypeInfoPropertyName = "CreateChatCompletionRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseObject), TypeInfoPropertyName = "CreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptSummaryObject), TypeInfoPropertyName = "PromptSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Prompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPromptVersionStatus), TypeInfoPropertyName = "PromptPromptVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryStatus), TypeInfoPropertyName = "PromptVersionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryObject), TypeInfoPropertyName = "PromptVersionSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestCreateCompletionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptCompletionRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptRenderRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptResponseObject), TypeInfoPropertyName = "CreatePromptResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPromptsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PromptSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>), TypeInfoPropertyName = "OneOfCreateChatCompletionResponseCreateCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionRequestModel?), TypeInfoPropertyName = "NullableCreateCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>?), TypeInfoPropertyName = "NullableOneOfStringIListStringIListInt32IListIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateCompletionResponseObject?), TypeInfoPropertyName = "NullableCreateCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType?), TypeInfoPropertyName = "NullableChatCompletionMessageContentPartThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType?), TypeInfoPropertyName = "NullableChatCompletionMessageContentPartRedactedThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestMessage?), TypeInfoPropertyName = "NullableChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestSystemMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestUserMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestToolMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolType?), TypeInfoPropertyName = "NullableChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOption?), TypeInfoPropertyName = "NullableChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum?), TypeInfoPropertyName = "NullableChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionNamedToolChoiceType?), TypeInfoPropertyName = "NullableChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionMessageContentBlock?), TypeInfoPropertyName = "NullableChatCompletionMessageContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChatCompletionResponseMessageRole?), TypeInfoPropertyName = "NullableChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestModel?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>?), TypeInfoPropertyName = "NullableOneOfResponseFormatTextResponseFormatJsonSchemaResponseFormatJsonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestThinkingType?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionRequestFunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionRequestFunctionCall?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateChatCompletionResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptSummaryObject?), TypeInfoPropertyName = "NullablePromptSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptPromptVersionStatus?), TypeInfoPropertyName = "NullablePromptPromptVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryStatus?), TypeInfoPropertyName = "NullablePromptVersionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PromptVersionSummaryObject?), TypeInfoPropertyName = "NullablePromptVersionSummaryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionRequestCreateCompletionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePromptResponseObject?), TypeInfoPropertyName = "NullableCreatePromptResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionResponseCreateCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PromptSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PromptVersionSummary>))]
    internal sealed partial class PromptsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionRequestMessageJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ChatCompletionMessageContentBlockJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateCompletionRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateChatCompletionRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>());
            options.Converters.Add(new global::Portkey.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole)

                    || typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatTextType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::Portkey.PromptSummaryObject)

                    || typeToConvert == typeof(global::Portkey.PromptSummaryObject?)

                    || typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus)

                    || typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus?)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject)

                    || typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject?)

                    || typeToConvert == typeof(global::Portkey.CreatePromptResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreatePromptResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseChoiceFinishReason?))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateCompletionResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartThinkingType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestSystemMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestDeveloperMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestUserMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestAssistantMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestToolMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionRequestFunctionMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionToolChoiceOptionEnum?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionNamedToolChoiceType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionMessageToolCallType?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ChatCompletionResponseMessageRole?))
                {
                    return new global::Portkey.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestThinkingType?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionRequestFunctionCall?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseChoiceFinishReason?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateChatCompletionResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonSchemaType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatTextType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatTextType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptSummaryObject))
                {
                    return new global::Portkey.JsonConverters.PromptSummaryObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptSummaryObject?))
                {
                    return new global::Portkey.JsonConverters.PromptSummaryObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus))
                {
                    return new global::Portkey.JsonConverters.PromptPromptVersionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptPromptVersionStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptPromptVersionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryStatus?))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PromptVersionSummaryObject?))
                {
                    return new global::Portkey.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreatePromptResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreatePromptResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreatePromptResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreatePromptResponseObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new PromptsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}