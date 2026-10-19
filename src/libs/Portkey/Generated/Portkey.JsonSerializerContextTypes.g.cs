
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicTextContent? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicTextContentType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicImageSource? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicImageSourceType? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicImageSourceMediaType? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicImageContent? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicImageContentType? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentSource? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentSourceType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentSourceMediaType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentContent? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentContentType? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentContentCitations? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolUseContent? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolUseContentType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolResultContent? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolResultContentType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicThinkingContent? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicThinkingContentType? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicRedactedThinkingContent? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicRedactedThinkingContentType? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicContentBlock? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicMessage? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicMessageRole? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicSystemContent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicSystemContentVariant2Item? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicSystemContentVariant2ItemType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicSystemContentVariant2ItemCacheControl? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicTool? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolCacheControl? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolCacheControlType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicThinkingConfig? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicThinkingConfigType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageRequestRole? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObject? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObject? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageRequestContentTextObject? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageRequestAttachment? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsCode? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnly? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicUsage? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponseType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponseRole? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponseStopReason? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensRequestToolChoice? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensRequestToolChoiceType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelPricingConfig? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelPayAsYouGo? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelCalculateConfig? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelPricingConfigCurrency? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelFinetuneConfig? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelTokenPrice? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelCalculateOperation? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelCalculateOperationOperation? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelValueReference? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Error? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ErrorResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateInvite? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceInvite? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteRole? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateInviteWorkspaceApiKeyDetails? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceInviteRole? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceInviteType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SuccessInvite? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsResponse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsResponseObject? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Model11>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Model11? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteModelResponse? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionRequestModel? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamOptions? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponse? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateCompletionResponseChoice>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoice? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoiceFinishReason? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoiceLogprobs? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseObject? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompletionUsage? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPart? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartText? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImage? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrl? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartTextType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinking? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinkingType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinking? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessage? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessage? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessage? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessage? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessage? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessage? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessage? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessageRole? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessageRole? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessageRole? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageRole? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCall>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageFunctionCall? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchTool? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComparisonFilter? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompoundFilter? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptions? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptionsRanker? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCall? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCallType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCallStatus? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FileSearchToolCallResult>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCallResult? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileAttributes? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessage? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageFunctionCall? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessageRole? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessageRole? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestFunctionMessage? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionParameters? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionFunctions? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionFunctionCallOption? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionTool? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionToolType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionObject? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOption? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOptionEnum? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoice? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceFunction? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputAudio? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputAudioType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputContent? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputText? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Refusal? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputItem? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessage? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCall? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolCall? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCall? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItem? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputItemDiscriminator? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputItemDiscriminatorType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessageType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessageRole? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputContent>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessageStatus? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputTextType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Annotation>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Annotation? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCall? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallFunction? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunk? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkType? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkFunction? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRole? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentBlock? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessage? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageRole? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageFunctionCall? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDelta? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaFunctionCall? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCallChunk>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaRole? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestModel? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatText? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchema? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonObject? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinking? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinkingType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestFunctionCall? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoice? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceFinishReason? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceLogprobs? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprob? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseObject? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionFunctionResponseChoice>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoice? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseObject? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprobTopLogprob? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJob? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponseObject? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionStreamResponseChoice>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoice? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceLogprobs? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseObject? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseUsage? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionImageResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequest? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestModel? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestQuality? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestResponseFormat? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestSize? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestStyle? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ImagesResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Image>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Image? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Includable? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionTool? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallStatus? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutput? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputStatus? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResource? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResourceVariant2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallResource? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallResourceVariant2? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputAudio? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputAudioType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputAudioFormat? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputContent? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputText? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputImage? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputFile? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputFileType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputImageType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputImageDetail? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputItem? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EasyInputMessage? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Item? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemReference? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputItemDiscriminator? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputItemDiscriminatorType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessage? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageRole? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageStatus? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputContent>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageResource? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageResourceVariant2? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputTextType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequestModel? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequestSize? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequestResponseFormat? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequestModel? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequestResponseFormat? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequestSize? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModelResponseProperties? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelResponseProperties? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationRequestModel? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateModerationResponseResult>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponseResult? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategories? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategoryScores? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseProperties? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateResponseVariant3? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputItem>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Includable>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesResponse? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OpenAIFile>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFile? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesResponseObject? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateFileRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateFileRequestPurpose? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteFileResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteFileResponseObject? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockFinetuneJob? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJob? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethod? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervised? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervisedHyperparameters? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpo? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpoHyperparameters? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockParams? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyFinetuneJob? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyOptions? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexFinetuneJob? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponse? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobEvent? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponseObject? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobCheckpoint? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponseObject? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestModel? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestEncodingFormat? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Embedding>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Embedding? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseObject? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseUsage? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankDocument? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankDocumentObject? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRerankRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankDocument>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankResult? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankResultDocument? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankUsage? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRerankResponse? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRerankResponseObject? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankResult>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrRequest? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrRequestDocument? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrRequestDocumentType? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrResponse? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OcrPage>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OcrPage? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrResponseUsageInfo? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OcrPageImage>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OcrPageImage? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestModel? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestResponseFormat? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestTimestampGranularitie? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseJson? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TranscriptionSegment? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TranscriptionWord? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseVerboseJson? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationRequestModel? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationResponseJson? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationResponseVerboseJson? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequest? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequestModel? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequestVoice? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequestResponseFormat? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelObject? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Move? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MoveType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFileObject? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFilePurpose? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFileStatus? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoubleClick? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoubleClickType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Drag? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DragType? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Coordinate>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Coordinate? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EasyInputMessageRole? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EasyInputMessageType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EmbeddingObject? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobError? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobHyperparameters? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobHyperparametersNEpochs? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobObject? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobStatus? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningIntegration? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningIntegrationType? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningIntegrationWandb? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobEventLevel? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobEventObject? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointMetrics? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointObject? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FinetuneChatRequestInput? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FinetuneCompletionRequestInput? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Click? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ClickType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ClickButton? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutput? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputFile? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutput? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutputType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterTool? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolCall? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallStatus? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolOutput? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComparisonFilterType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, double?, bool?>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompleteUploadRequest? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompletionUsageCompletionTokensDetails? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompletionUsagePromptTokensDetails? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompoundFilterType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerAction? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.KeyPress? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Screenshot? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Scroll? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Type? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Wait? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerScreenshotImage? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerScreenshotImageType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerTool? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolType? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolEnvironment? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallSafetyCheck? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallStatus? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutput? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputStatus? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResource? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResourceVariant2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Content6? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CostsResult? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CostsResultObject? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CostsResultAmount? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Reasoning? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningEffort? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningGenerateSummary? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItem? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItemType? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemStatus? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RefusalType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Response? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3Object? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3Status? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseError? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetails? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetailsReason? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputItem>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseUsage? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEvent? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEventType? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDoneEvent? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDoneEventType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEventType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEvent? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEventType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEventType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEventType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCompletedEvent? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCompletedEventType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEvent? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEventType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEvent? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEventType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCreatedEvent? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCreatedEventType? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseErrorCode? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseErrorEvent? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseErrorEventType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFailedEvent? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFailedEventType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEvent? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEventType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEvent? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEventType? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEvent? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEventType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonObjectType? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaJsonSchema? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaSchema? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatTextType? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEventType? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEventType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseInProgressEvent? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseInProgressEventType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseIncompleteEvent? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseIncompleteEventType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseItemList? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseItemListObject? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ItemResource>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemResource? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseModalitie? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseModalitiesTextOnlyItem? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEvent? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEventType? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEvent? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEventType? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponsePropertiesText? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TextResponseFormatConfiguration? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Tool>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Tool? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceOptions? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceTypes? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceFunction? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponsePropertiesTruncation? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEvent? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEventType? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEvent? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEventType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseStreamEvent? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEvent? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDeltaEvent? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDoneEvent? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEvent? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEvent? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEvent? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminator? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminatorType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEventType? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDeltaEventType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDoneEventType? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseUsageInputTokensDetails? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseUsageOutputTokensDetails? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEventType? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEventType? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEventType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunCompletionUsage? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepCompletionUsage? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOption? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOptionEnum? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormat? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatType? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileCitation? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UrlCitation? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FilePath? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObject? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectObject? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearch? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFunction? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectToolResources? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesCodeInterpreter? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesFileSearch? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequest? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestModel? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResources? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearch? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelIdsResponses? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelIdsResponsesEnum? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequest? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResources? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesFileSearch? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteAssistantResponse? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteAssistantResponseObject? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemDiscriminator? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemDiscriminatorType? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemReferenceType? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemResourceDiscriminator? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemResourceDiscriminatorType? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.KeyPressType? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAssistantsResponse? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AssistantObject>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsCodeType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchType? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchFileSearch? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnlyType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFunctionType? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TruncationObject? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TruncationObjectType? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOption? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoice? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceFunction? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObject? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectObject? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectStatus? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectRequiredAction? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectRequiredActionType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectRequiredActionSubmitToolOutputs? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunToolCallObject? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectLastError? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectLastErrorCode? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetails? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetailsReason? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRunRequest? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRunRequestModel? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunsResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunObject>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyRunRequest? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequest? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequestToolOutput? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchema? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchemaType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunToolCallObjectType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunToolCallObjectFunction? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScreenshotType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScrollType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequest? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequest? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestModel? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResources? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObject? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectObject? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectToolResources? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesCodeInterpreter? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesFileSearch? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResources? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearch? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequest? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResources? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesFileSearch? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteThreadResponse? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteThreadResponseObject? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListThreadsResponse? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ThreadObject>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObject? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectObject? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectStatus? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetails? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetailsReason? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectRole? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextObject? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectAttachment? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObject? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObjectObject? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObjectDelta? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObjectDeltaRole? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObject? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObject? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObject? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyMessageRequest? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteMessageResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteMessageResponseObject? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListMessagesResponse? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObject>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectType? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFile? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFileDetail? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFile? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectType? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrl? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectType? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrl? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextObjectType? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextObjectText? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObject? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObject? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageRequestContentTextObjectType? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectType? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectType? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectText? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObject? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectObject? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectType? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectStatus? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObject? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObject? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectLastError? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectLastErrorCode? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaObject? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaObjectObject? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaObjectDelta? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObject? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObject? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunStepsResponse? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunStepObject>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectType? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObjectType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObject? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObject? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObject? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObjectType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectType? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfter? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfterAnchor? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObject? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObjectObject? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObjectFileCounts? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObjectStatus? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchRequest? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptions? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObject? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObjectType? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultItem? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultContentObject>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPage? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPageObject? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultItem>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VoiceIdsShared? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VoiceIdsSharedEnum? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WaitType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchContextSize? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchLocation? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchTool? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolUserLocation? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolUserLocationType? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolCallType? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolCallStatus? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVectorStoreRequest? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParam? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParam? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TypeType1? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateVectorStoreRequest? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UrlCitationType? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoresResponse? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponse? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponseObject? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObject? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectObject? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectStatus? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastError? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastErrorCode? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParam? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParam? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParamType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParamType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategy? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParamType? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParamType? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChunkingStrategyRequestParam? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVectorStoreFileRequest? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoreFilesResponse? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponse? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponseObject? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObject? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectObject? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectStatus? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectFileCounts? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVectorStoreFileBatchRequest? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantStreamEvent? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadStreamEvent? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEvent? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEvent? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEvent? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ErrorEvent? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoneEvent? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1Event? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceFunctionType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceTypesType? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant1? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant1Event? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant2? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant2Event? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant3? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant3Event? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant4? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant4Event? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant5? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant5Event? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant6? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant6Event? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant7? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant7Event? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant8? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant8Event? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant9? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant9Event? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant10? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant10Event? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1Event? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2Event? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3Event? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4Event? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5Event? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6Event? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7Event? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1Event? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2Event? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3Event? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4Event? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5Event? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ErrorEventEvent? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileCitationType? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FilePathType? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoneEventEvent? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoneEventData? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Batch? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchObject? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchErrors? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchErrorsDataItem? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchStatus? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestCounts? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestInput? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestInputMethod? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestOutput? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestOutputResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestOutputError? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListBatchesResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Batch>? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListBatchesResponseObject? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FeedbackRequest? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FeedbackResponse? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FeedbackUpdateRequest? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimits? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsType? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsUnit? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimits? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsType? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPeriodicReset? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateIntegrationRequest? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIConfiguration? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicConfiguration? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureOpenAIConfiguration? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockConfiguration? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexAIConfiguration? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureAIConfiguration? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkersAIConfiguration? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SageMakerConfiguration? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HuggingFaceConfiguration? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CortexConfiguration? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomHostConfiguration? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretMapping? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingAdjustments? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateIntegrationRequest? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationDetailResponse? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationList? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationDetailResponseVariant2? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GlobalWorkspaceAccess? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingMultiplier? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingMultiplierImage? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIConfigurationProviderAuthType? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIConfigurationWifIdentitySource? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicConfigurationProviderAuthType? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicConfigurationWifIdentitySource? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureDeploymentConfig? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockConfigurationAwsAuthType? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SageMakerConfigurationVariant2? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexAIConfigurationVertexAuthType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureAIConfigurationAzureAuthMode? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretMappingValueFormat? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequest? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestManagerType? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuthConfig? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfig? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfig? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfig? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureEntraAuthConfig? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureManagedAuthConfig? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfig? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfig? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfig? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfig? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateSecretReferenceRequest? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItem? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItemManagerType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItemStatus? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItemObject? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponse? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseManagerType? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseStatus? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseObject? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfigAwsAuthType? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfigAwsAuthType? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureEntraAuthConfigAzureAuthMode? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureManagedAuthConfigAzureAuthMode? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfigAzureAuthMode? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfigVaultAuthType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationListStatus? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationListObject? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationModelsResponse? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationModel>? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationModel? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingConfig? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingConfigType? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PayAsYouGoPricing? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TokenPricing? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelConfigurations? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelConfigurationsCustomHeaders? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateModelsRequest? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelUpdateRequest? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationWorkspacesResponse? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationWorkspace? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateWorkspacesRequest? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceUpdateRequest? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Providers? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ProvidersStatus? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ProvidersObject? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VirtualKeys? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VirtualKeysStatus? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VirtualKeysObject? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Invite? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteRole2? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteStatus? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteList? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteListObject? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Invite>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.User? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserObject? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserRole? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserList? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserListObject? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.User>? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMember? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberObject? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberOrgRole? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberRole? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberStatus? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberList? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberListObject? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Workspace? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceDefaults? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceDefaultsObject? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceList? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceListObject? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Workspace>? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceWithUsers? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaults? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaultsObject? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScimWorkspaceMapping? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScimWorkspaceMappingRole? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Collection? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionStatus? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionDetails? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithDetails? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithDetailsVariant2? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChildCollection? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithChildCollections? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithChildCollectionsVariant2? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChildCollection>? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Label? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateLabelRequest? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateLabelRequest? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateLabelResponse? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListLabelsResponse? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Label>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptSummary? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptSummaryObject? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Prompt2? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPromptVersionStatus? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptVersionSummary? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptVersionSummaryStatus? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptVersionSummaryObject? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialSummary? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialSummaryStatus? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialSummaryObject? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartial? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialStatus? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialVersion? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialVersionPromptVersionStatus? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialVersionObject? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLog? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLogRequest? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLogResponse? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLogMetadata? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportListResponse? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportListResponseObject? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ExportItem>? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportItem? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GenerationsFilterSchema? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportItemStatus? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportItemObject? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateExportResponse? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateExportResponseObject? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportTaskResponse? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportTaskResponseObject? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DownloadLogsResponse? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogObject? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogRequest? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogResponse? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnalyticsMetrics? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RequestResponseObject? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogRequestMethod? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogExportsRequestedDataItem? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectList? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListRecord? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordMethod? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordUserType? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListObject? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObject? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectType? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectStatus? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectCreationMode? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectRateLimit? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectDefaults? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectObject? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectList? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectListObject? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObject? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimit? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitType? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitUnit? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectDefaults? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicy? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObject? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimit? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitType? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitUnit? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectDefaults? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicy? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RotateApiKeyRequest? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RotateApiKeyResponse? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptRenderResponse? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateGuardrailRequest? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateGuardrailRequestTarget? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailCheck? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActions? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateGuardrailRequest? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccess? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccessFeedback? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnFail? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnFailFeedback? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailCheckId? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JWTParameters? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelWhitelistParameters? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RegexMatchParameters? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SentenceCountParameters? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WordCountParameters? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CharacterCountParameters? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JSONSchemaParameters? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JSONKeysParameters? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsParameters? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ValidUrlsParameters? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsCodeParameters? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebhookParameters? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EndsWithParameters? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UppercaseParameters? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParameters? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllowedRequestTypesParameters? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SydeGuardParameters? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AporiaParameters? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PillarScanParameters? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PatronusParameters? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PatronusCustomParameters? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyModerationParameters? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyLanguageParameters? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyPIIParameters? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MistralModerationParameters? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockGuardParameters? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptfooParameters? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParameters? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureContentSafetyParameters? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzurePIIParameters? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PANWPrismaParameters? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BasicParameters? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateGuardrailResponse? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateGuardrailResponse? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListGuardrailsResponse? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailSummary? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailSummaryTarget? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailSummaryStatus? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailDetails? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailDetailsVariant2? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerMapping>? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerMapping? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerMappingRunOnItem>? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerMappingRunOnItem? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsRequest? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsResponse? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpsertMcpServerMappingRequest? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpsertMcpServerMappingRequestRunOnItem>? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpsertMcpServerMappingRequestRunOnItem? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpsertMcpServerMappingResponse? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JSONKeysParametersOperator? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsParametersOperator? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsCodeParametersFormat? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParametersOperator? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersAllowedType? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersBlockedType? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PillarScanParametersScanner? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyModerationParametersCategorie? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyLanguageParametersLanguage? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyPIIParametersCategorie? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MistralModerationParametersCategorie? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParametersLanguageValues? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParametersPiiCategorie? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParametersSecretsCategorie? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureContentSafetyParametersCategorie? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzurePIIParametersDomain? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockBatchJob? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIBatchJob? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockBatchParams? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CommonBatchParams? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIBatchJobCompletionWindow? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIBatchJobEndpoint? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchJob? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchOptions? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexBatchJob? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexBatchParams? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Condition? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GroupBy? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequest? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GroupBy>? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestType? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequest? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequest? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestType? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestUnit? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestTarget? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequest? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicy? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyType? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyPeriodicReset? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyStatus? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ValueKeyUsage? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ValueKeyUsageStatus? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicy? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyType? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyUnit? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyStatus? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyTarget? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePolicyResponse? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyListResponse? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponse? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntity? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntityListResponse? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyListResponse? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponse? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegration? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegrationConfigurations? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegrationAuthType? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegrationTransport? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCreateResponse? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegration? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationAuthType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationTransport? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItem? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItemType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItemAuthType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItemTransport? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListResponse? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegration? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationConfigurations? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationAuthType? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationTransport? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationWorkspaceItem? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesListResponse? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesLegacyResponse? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspaces? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItem? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItemType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCounts? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListResponse? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilities? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationMetadata? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpServer? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCreateResponse? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServer? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerMcpIntegrationDetails? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerListItem? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerListResponse? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpServer? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerTestResponse? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilityItem? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilityItemType? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCounts? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsTools? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsPrompts? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResources? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResourceTemplates? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListResponse? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilities? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesBulkUpdateResponse? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessItem? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessItemConnectionStatus? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponse? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponseDefaultUserAccess? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccess? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessUserAcces? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessBulkUpdateResponse? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerConnectionItem? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerConnectionsListResponse? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerConnectionItem>? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerConnectionDeleteResponse? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentAuthSettings? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentAuthSettingsInput? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentCredentials? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateDeploymentRequest? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateDeploymentRequestType? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequest? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequestType? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequestStatus? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequestAuthSettings? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentCreateResponse? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentCreateResponseObject? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItem? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemType? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemStatus? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemConnectionStatus? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemObject? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponse? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2AuthSettings? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.DeploymentDetailResponseVariant2Workspace>? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2Workspace? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponse? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseStatus? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseOutbound? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseOutboundStatus? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseInbound? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseInboundStatus? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseObject? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEgressAllowlistRequest? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateEgressAllowlistRequest? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EgressAllowlistEntry? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EgressAllowlistEntryStatus? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EgressAllowlistEntryObject? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubject? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubjectType? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubjectDetails? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubjectDetailsType? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTarget? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTarget? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTarget? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTargetDiscriminator? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTargetDiscriminatorType? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTargetType? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AccessPolicyMcpServerTargetTools?, global::System.Collections.Generic.IList<string>>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTargetTools? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTargetType? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AccessPolicyProviderTargetModels?, global::System.Collections.Generic.IList<string>>? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTargetModels? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyRequest? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyRequestEffect? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateAccessPolicyRequest? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateAccessPolicyRequestEffect? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicy? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyEffect? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubjectDetails>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyStatus? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyObject? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItem? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItemEffect? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItemStatus? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItemObject? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCollectionsRequest? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutCollectionsRequest? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptRequest? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptRequest? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptVersionRequest? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptDefaultRequest? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptPartialRequest? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptPartialRequest? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptPartialDefaultRequest? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptCompletionRequest2? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptRenderRequest2? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateConfigRequest? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigRequest? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigRequestConfig? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateProvidersRequest? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutProvidersRequest? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequest? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestProvider? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysRequest? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysRequestDeploymentConfigItem? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminUsersRequest? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminUsersRequestRole? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequest? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUser? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUserRole? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequest? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequest? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequest? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequestDefaults? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateScimWorkspacesRequest? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateScimWorkspacesRequestRole? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CustomLog>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutLogsExportsRequest? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateLogsExportsRequest? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsSort? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsOrder? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAssistantsOrder? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListInputItemsOrder? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListMessagesOrder? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunsOrder? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunStepsOrder? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoresOrder? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoreFilesOrder? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoreFilesFilter? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchOrder? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchFilter? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetIntegrationsType? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesRole? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesStatus? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminUsersRole? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminWorkspacesUsersRole? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminWorkspacesStatus? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesRole? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationsListType? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListType? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetLogsPathFormat? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetLogsType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAuditLogsMethod? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAuditLogsUserType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysType? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysSubType? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesStatus? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetUsageLimitsPolicyStatus? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListUsageLimitsPolicyEntitiesStatus? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesStatus? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesType? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesUnit? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesTarget? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetRateLimitsPolicyStatus? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAccessPoliciesEffect? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderIncludeTotal? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListSecretReferencesManagerType? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsStatus? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsType? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCollectionsResponse? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetCollectionsResponse? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptResponse? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptResponseObject? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListPromptsResponse? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptSummary>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptResponse? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptPartialResponse? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptPartialResponse? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptCompletionResponse? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigsResponse? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigsResponseDataItem? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateConfigResponse? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateConfigResponseData? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponse? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseData? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfig? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigRetry? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigCache? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigStrategy? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigTarget? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigResponse? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigResponseData? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigVersionsResponse? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigVersionsResponseDataItem? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetIntegrationsResponse? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetIntegrationsResponseObject? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationList>? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateIntegrationsResponse? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetProvidersResponse? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetProvidersResponseObject? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Providers>? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateProvidersResponse? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutProvidersResponse? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseObject? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse2? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse2? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData2? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse3? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData2? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysResponse2? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysResponseData? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponse2? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponseData? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminUsersInvitesResendResponse? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponse? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponseMapping? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponseMappingRole? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteScimWorkspacesResponse? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysResponse? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysResponseObject? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyResponse? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyResponseObject? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAccessPoliciesResponse? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAccessPoliciesResponseObject? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicyListItem>? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponse? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseSummary? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseObject? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponse? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseSummary? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseDataPoint? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseObject? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponse? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseSummary? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseObject? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponse? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseSummary? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseObject? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponse? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseSummary? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseObject? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponse? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponse? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseSummary? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseObject? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponse? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponse? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponse? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponse? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponse? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponse? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseSummary? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseObject? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponse? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseObject? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItem? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponse? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderResponse? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderResponseObject? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderResponseDataItem? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponse? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseObject? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponse? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponseObject? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMcpResponseDataItem>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponseDataItem? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponse? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponseObject? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem>? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponseDataItem? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponse? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem>? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetModelPricingResponse? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListSecretReferencesResponse? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListSecretReferencesResponseObject? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponse? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponseObject? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsResponse? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsResponseObject? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.DeploymentListItem>? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListEgressAllowlistResponse? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListEgressAllowlistResponseObject? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.EgressAllowlistEntry>? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEgressAllowlistEntryResponse? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEgressAllowlistEntryResponseObject? Type1772 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.AnthropicContentBlock>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AnthropicContentBlock>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AnthropicSystemContentVariant2Item>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequestAttachment>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AnthropicMessage>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AnthropicTool>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceInvite>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Model11>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateCompletionResponseChoice>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCall>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FileSearchToolCallResult>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputContent>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Annotation>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageContentBlock>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCallChunk>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessage>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTool>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionFunctions>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionResponseChoice>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprob>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionFunctionResponseChoice>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJob>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionStreamResponseChoice>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Image>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.InputContent>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateModerationResponseResult>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputItem>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.InputItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Includable>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OpenAIFile>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJobEvent>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJobCheckpoint>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Embedding>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RerankDocument>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RerankResult>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OcrPage>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OcrPageImage>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionWord>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionSegment>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Coordinate>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputContent>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningIntegration>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterFileOutputFile>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterToolOutput>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ComputerToolCallSafetyCheck>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ReasoningItemSummaryItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputItem>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ItemResource>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitie>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitiesTextOnlyItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Tool>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AssistantObject>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunToolCallObject>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequest>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunObject>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ThreadObject>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObjectAttachment>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObject>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunStepObject>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultContentObject>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreSearchResultItem>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreObject>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VectorStoreFileObject>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BatchErrorsDataItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Batch>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SecretMapping>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimits>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RateLimits>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AzureDeploymentConfig>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationModel>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ModelUpdateRequest>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationWorkspace>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceUpdateRequest>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Invite>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.User>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceMember>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Workspace>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChildCollection>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Label>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ExportItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.LogExportsRequestedDataItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AuditLogObjectListRecord>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ApiKeyObjectRateLimit>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ApiKeyObject>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateApiKeyObjectRateLimit>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UpdateApiKeyObjectRateLimit>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GuardrailCheck>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GuardrailSummary>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerMapping>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerMappingRunOnItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UpsertMcpServerMappingRequestRunOnItem>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersAllowedType>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AllowedRequestTypesParametersBlockedType>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PillarScanParametersScanner>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PortkeyModerationParametersCategorie>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PortkeyPIIParametersCategorie>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MistralModerationParametersCategorie>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersPiiCategorie>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AcuvityScanParametersSecretsCategorie>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AzureContentSafetyParametersCategorie>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Condition>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GroupBy>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicy>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicyEntity>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RateLimitsPolicy>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationListItem>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationWorkspaceItem>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpIntegrationCapabilityItem>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerListItem>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerCapabilityItem>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerUserAccessItem>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.McpServerConnectionItem>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.DeploymentDetailResponseVariant2Workspace>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AccessPolicyMcpServerTargetTools?, global::System.Collections.Generic.List<string>>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AccessPolicyProviderTargetModels?, global::System.Collections.Generic.List<string>>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AccessPolicySubject>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AccessPolicyTarget>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AccessPolicySubjectDetails>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.List<global::Portkey.CustomLog>>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CustomLog>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CollectionWithDetails>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptSummary>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptVersionSummary>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptPartialSummary>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.PromptPartialVersion>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ListConfigsResponseDataItem>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetConfigResponseDataConfigTarget>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ListConfigVersionsResponseDataItem>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.IntegrationList>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Providers>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.VirtualKeys>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetScimWorkspacesResponseMapping>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AccessPolicyListItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMcpResponseDataItem>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SecretReferenceListItem>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.DeploymentListItem>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.EgressAllowlistEntry>? ListType198 { get; set; }
    }
}