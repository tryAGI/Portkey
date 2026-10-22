
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
        public global::Portkey.CreateAnthropicMessageRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAnthropicMessageRequestToolChoice? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAnthropicMessageRequestToolChoiceType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAnthropicMessageRequestMetadata? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicUsage? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponseType? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponseRole? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageResponseStopReason? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensRequestToolChoice? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensRequestToolChoiceType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CountMessageTokensResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelPricingConfig? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelPayAsYouGo? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelCalculateConfig? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelPricingConfigCurrency? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelFinetuneConfig? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelTokenPrice? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Portkey.ModelTokenPrice>>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelCalculateOperation? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelCalculateOperationOperation? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelValueReference? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Error? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ErrorResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateInvite? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceInvite? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteRole? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateInviteWorkspaceApiKeyDetails? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceInviteRole? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceInviteType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SuccessInvite? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsResponseObject? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Model11>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Model11? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteModelResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateCompletionRequestModel?>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionRequestModel? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamOptions? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponse? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateCompletionResponseChoice>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoice? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoiceFinishReason? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseChoiceLogprobs? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCompletionResponseObject? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompletionUsage? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPart? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartText? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImage? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrl? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessageContentPartTextType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinking? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartThinkingType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinking? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinkingType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestMessage? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessage? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessage? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessage? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessage? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessage? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessage? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestSystemMessageRole? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestDeveloperMessageRole? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessageContentPart>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestUserMessageRole? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageRole? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCall>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestAssistantMessageFunctionCall? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchTool? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComparisonFilter? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompoundFilter? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptions? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolRankingOptionsRanker? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCall? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCallType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCallStatus? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FileSearchToolCallResult>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileSearchToolCallResult? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileAttributes? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessage? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageRole? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestAssistantMessageFunctionCall? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestToolMessageRole? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRequestFunctionMessageRole? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuneChatCompletionRequestFunctionMessage? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionParameters? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionFunctions? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionFunctionCallOption? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionTool? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionToolType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionObject? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOption? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionToolChoiceOptionEnum? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoice? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionNamedToolChoiceFunction? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputAudio? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputAudioType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputContent? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputText? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Refusal? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputItem? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCall? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolCall? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCall? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItem? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputItemDiscriminator? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputItemDiscriminatorType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessageType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessageRole? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputContent>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputMessageStatus? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OutputTextType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Annotation>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Annotation? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCall? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallFunction? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunk? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageToolCallChunkFunction? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionRole? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionMessageContentBlock? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessage? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageRole? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionResponseMessageFunctionCall? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageContentBlock>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDelta? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaFunctionCall? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionMessageToolCallChunk>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionStreamResponseDeltaRole? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionRequestMessage>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateChatCompletionRequestModel?>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestModel? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ResponseFormatText, global::Portkey.ResponseFormatJsonSchema, global::Portkey.ResponseFormatJsonObject>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatText? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchema? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonObject? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinking? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestThinkingType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTool>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequestFunctionCall?, global::Portkey.ChatCompletionFunctionCallOption>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionRequestFunctionCall? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionFunctions>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionResponseChoice>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoice? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceFinishReason? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseChoiceLogprobs? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprob>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprob? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionResponseObject? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionFunctionResponseChoice>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoice? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseChoiceFinishReason? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionFunctionResponseObject? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChatCompletionTokenLogprobTopLogprob? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJob? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListPaginatedFineTuningJobsResponseObject? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateChatCompletionStreamResponseChoice>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoice? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceLogprobs? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseChoiceFinishReason? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseObject? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionStreamResponseUsage? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateChatCompletionImageResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequest? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestModel? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestQuality? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestResponseFormat? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestSize? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageRequestStyle? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ImagesResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Image>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Image? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Includable? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionTool? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallType? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallStatus? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutput? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputStatus? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResource? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallOutputResourceVariant2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallResource? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FunctionToolCallResourceVariant2? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputAudio? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputAudioType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputAudioFormat? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputContent? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputText? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputImage? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputFile? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputFileType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputImageType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputImageDetail? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputItem? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EasyInputMessage? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Item? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemReference? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputItemDiscriminator? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputItemDiscriminatorType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessage? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageRole? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageStatus? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputContent>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageResource? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputMessageResourceVariant2? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InputTextType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequestModel? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequestSize? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageEditRequestResponseFormat? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequestModel? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequestResponseFormat? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateImageVariationRequestSize? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModelResponseProperties? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelResponseProperties? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateModerationRequestModel?>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationRequestModel? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateModerationResponseResult>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponseResult? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategories? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateModerationResponseResultCategoryScores? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseProperties? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateResponseVariant3? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.InputItem>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Includable>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OpenAIFile>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFile? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesResponseObject? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateFileRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateFileRequestPurpose? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteFileResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteFileResponseObject? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockFinetuneJob? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJob? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethod? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervised? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodSupervisedHyperparameters? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpo? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFinetuneJobMethodDpoHyperparameters? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockParams? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyFinetuneJob? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyOptions? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexFinetuneJob? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobEvent? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobEventsResponseObject? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponse? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobCheckpoint? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFineTuningJobCheckpointsResponseObject? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingRequest? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestModel? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingRequestEncodingFormat? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Embedding>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Embedding? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseObject? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEmbeddingResponseUsage? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankDocument? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankDocumentObject? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRerankRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankDocument>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankResult? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankResultDocument? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RerankUsage? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRerankResponse? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRerankResponseObject? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RerankResult>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrRequest? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrRequestDocument? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrRequestDocumentType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrResponse? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OcrPage>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OcrPage? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateOcrResponseUsageInfo? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OcrPageImage>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OcrPageImage? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequest? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestModel? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestResponseFormat? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionRequestTimestampGranularitie? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseJson? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TranscriptionSegment? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TranscriptionWord? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranscriptionResponseVerboseJson? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationRequest? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationRequestModel? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationResponseJson? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateTranslationResponseVerboseJson? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequestModel? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequestVoice? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSpeechRequestResponseFormat? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelObject? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Move? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MoveType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFileObject? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFilePurpose? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIFileStatus? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoubleClick? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoubleClickType? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Drag? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DragType? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Coordinate>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Coordinate? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EasyInputMessageRole? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EasyInputMessageType? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EmbeddingObject? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobError? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobHyperparameters? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobHyperparametersNEpochs? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobObject? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobStatus? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningIntegration? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningIntegrationType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningIntegrationWandb? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobEventLevel? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobEventObject? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointMetrics? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FineTuningJobCheckpointObject? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FinetuneChatRequestInput? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FinetuneCompletionRequestInput? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Click? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ClickType? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ClickButton? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutput? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterFileOutputFile? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutput? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterTextOutputType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterTool? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolCall? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallType? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolCallStatus? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CodeInterpreterToolOutput? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComparisonFilterType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, double?, bool?>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompleteUploadRequest? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompletionUsageCompletionTokensDetails? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompletionUsagePromptTokensDetails? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CompoundFilterType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerAction? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.KeyPress? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Screenshot? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Scroll? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Type? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Wait? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerScreenshotImage? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerScreenshotImageType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerTool? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolEnvironment? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallSafetyCheck? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallStatus? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutput? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputType? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputStatus? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResource? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ComputerToolCallOutputResourceVariant2? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Content5? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CostsResult? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CostsResultObject? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CostsResultAmount? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Reasoning? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningEffort? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningGenerateSummary? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItem? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemSummaryItemType? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ReasoningItemStatus? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RefusalType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Response? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3Object? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3Status? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseError? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetails? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseVariant3IncompleteDetailsReason? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OutputItem>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseUsage? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEvent? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDeltaEventType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDoneEvent? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioDoneEventType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEvent? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDeltaEventType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEvent? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseAudioTranscriptDoneEventType? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEvent? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallCompletedEventType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEvent? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCodeInterpreterCallInterpretingEventType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCompletedEvent? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCompletedEventType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEvent? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartAddedEventType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEvent? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseContentPartDoneEventType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCreatedEvent? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseCreatedEventType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseErrorCode? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseErrorEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseErrorEventType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFailedEvent? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFailedEventType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEvent? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallCompletedEventType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEvent? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallInProgressEventType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEvent? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFileSearchCallSearchingEventType? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonObjectType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaJsonSchema? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatJsonSchemaSchema? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFormatTextType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDeltaEventType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEvent? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseFunctionCallArgumentsDoneEventType? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseInProgressEvent? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseInProgressEventType? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseIncompleteEvent? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseIncompleteEventType? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseItemList? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseItemListObject? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ItemResource>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemResource? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitie>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseModalitie? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ResponseModalitiesTextOnlyItem>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseModalitiesTextOnlyItem? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEvent? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemAddedEventType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEvent? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseOutputItemDoneEventType? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponsePropertiesText? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TextResponseFormatConfiguration? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Tool>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Tool? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceOptions? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceTypes? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceFunction? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponsePropertiesTruncation? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEvent? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDeltaEventType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEvent? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseRefusalDoneEventType? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseStreamEvent? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEvent? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDeltaEvent? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDoneEvent? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEvent? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEvent? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEvent? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminator? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseStreamEventDiscriminatorType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextAnnotationDeltaEventType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDeltaEventType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseTextDoneEventType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseUsageInputTokensDetails? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseUsageOutputTokensDetails? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallCompletedEventType? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallInProgressEventType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ResponseWebSearchCallSearchingEventType? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunCompletionUsage? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepCompletionUsage? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOption? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatOptionEnum? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormat? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiResponseFormatType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileCitation? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UrlCitation? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FilePath? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObject? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectObject? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsCode? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearch? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFunction? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectToolResources? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesCodeInterpreter? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantObjectToolResourcesFileSearch? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequest? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateAssistantRequestModel?>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestModel? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResources? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesCodeInterpreter? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearch? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelIdsResponses? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelIdsResponsesEnum? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequest? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResources? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesCodeInterpreter? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyAssistantRequestToolResourcesFileSearch? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteAssistantResponse? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteAssistantResponseObject? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemDiscriminator? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemDiscriminatorType? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemReferenceType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemResourceDiscriminator? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ItemResourceDiscriminatorType? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.KeyPressType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAssistantsResponse? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AssistantObject>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsCodeType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchFileSearch? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnly? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFileSearchTypeOnlyType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantToolsFunctionType? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TruncationObject? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TruncationObjectType? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOption? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoice? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantsNamedToolChoiceFunction? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObject? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectObject? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectStatus? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectRequiredAction? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectRequiredActionType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectRequiredActionSubmitToolOutputs? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunToolCallObject>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunToolCallObject? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectLastError? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectLastErrorCode? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetails? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunObjectIncompleteDetailsReason? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRunRequest? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateRunRequestModel?>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRunRequestModel? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequest>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageRequest? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunsResponse? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunObject>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyRunRequest? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequest? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SubmitToolOutputsRunRequestToolOutput? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchema? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TextResponseFormatJsonSchemaType? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunToolCallObjectType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunToolCallObjectFunction? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScreenshotType? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScrollType? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequest? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequest? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<string, global::Portkey.CreateThreadAndRunRequestModel?>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestModel? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResources? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadAndRunRequestToolResourcesFileSearch? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObject? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectObject? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectToolResources? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesCodeInterpreter? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadObjectToolResourcesFileSearch? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResources? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesCodeInterpreter? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearch? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequest? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResources? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesCodeInterpreter? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyThreadRequestToolResourcesFileSearch? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteThreadResponse? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteThreadResponseObject? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListThreadsResponse? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ThreadObject>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObject? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectObject? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectStatus? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetails? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectIncompleteDetailsReason? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectRole? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObject? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObject? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextObject? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObjectAttachment>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageObjectAttachment? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObject? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObjectObject? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObjectDelta? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaObjectDeltaRole? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObject? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObject? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObject? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageRequestRole? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageRequestContentTextObject? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMessageRequestAttachment? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModifyMessageRequest? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteMessageResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteMessageResponseObject? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListMessagesResponse? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MessageObject>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectType? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFile? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageFileObjectImageFileDetail? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFile? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageFileObjectImageFileDetail? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectType? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrl? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectType? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrl? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentImageUrlObjectImageUrlDetail? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextObjectType? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextObjectText? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageContentTextAnnotationsFileCitationObject, global::Portkey.MessageContentTextAnnotationsFilePathObject>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObject? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObject? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageRequestContentTextObjectType? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageContentTextAnnotationsFilePathObjectFilePath? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectType? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextObjectText? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject, global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObject? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObject? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectType? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObject? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectObject? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectType? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectStatus? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsMessageCreationObject, global::Portkey.RunStepDetailsToolCallsObject>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObject? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObject? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectLastError? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepObjectLastErrorCode? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaObject? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaObjectObject? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaObjectDelta? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsMessageCreationObject, global::Portkey.RunStepDeltaStepDetailsToolCallsObject>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObject? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObject? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunStepsResponse? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RunStepObject>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsMessageCreationObjectMessageCreation? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectType? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsObjectType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObject? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObject? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObject? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsObjectType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObject? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObject? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectType? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObject? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObject? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFileSearchObjectType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectType? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDetailsToolCallsFunctionObjectFunction? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfter? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreExpirationAfterAnchor? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObject? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObjectObject? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObjectFileCounts? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreObjectStatus? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchRequest? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptions? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObject? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultContentObjectType? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultItem? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultContentObject>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPage? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreSearchResultsPageObject? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreSearchResultItem>? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VoiceIdsShared? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VoiceIdsSharedEnum? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WaitType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchContextSize? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchLocation? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchTool? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolType? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolUserLocation? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolUserLocationType? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolCallType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebSearchToolCallStatus? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVectorStoreRequest? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParam? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParam? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TypeType1? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateVectorStoreRequest? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UrlCitationType? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoresResponse? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponse? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreResponseObject? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObject? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectObject? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectStatus? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastError? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileObjectLastErrorCode? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParam? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParam? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OtherChunkingStrategyResponseParamType? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyResponseParamType? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategy? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AutoChunkingStrategyRequestParamType? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.StaticChunkingStrategyRequestParamType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChunkingStrategyRequestParam? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVectorStoreFileRequest? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoreFilesResponse? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponse? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVectorStoreFileResponseObject? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObject? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectObject? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectStatus? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VectorStoreFileBatchObjectFileCounts? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVectorStoreFileBatchRequest? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AssistantStreamEvent? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadStreamEvent? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEvent? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEvent? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEvent? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ErrorEvent? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoneEvent? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ThreadStreamEventVariant1Event? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceFunctionType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ToolChoiceTypesType? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant1? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant1Event? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant2? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant2Event? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant3? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant3Event? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant4? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant4Event? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant5? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant5Event? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant6? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant6Event? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant7? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant7Event? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant8? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant8Event? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant9? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant9Event? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant10? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStreamEventVariant10Event? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant1Event? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant2Event? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant3Event? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant4Event? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant5Event? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant6Event? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RunStepStreamEventVariant7Event? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant1Event? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant2Event? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant3Event? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant4Event? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MessageStreamEventVariant5Event? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ErrorEventEvent? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FileCitationType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FilePathType? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoneEventEvent? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DoneEventData? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Batch? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchObject? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchErrors? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchErrorsDataItem? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchStatus? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestCounts? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestInput? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestInputMethod? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestOutput? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestOutputResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BatchRequestOutputError? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListBatchesResponse? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Batch>? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListBatchesResponseObject? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FeedbackRequest? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FeedbackResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.FeedbackUpdateRequest? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimits? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsUnit? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimits? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPeriodicReset? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateIntegrationRequest? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIConfiguration? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicConfiguration? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureOpenAIConfiguration? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockConfiguration? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexAIConfiguration? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureAIConfiguration? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkersAIConfiguration? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SageMakerConfiguration? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HuggingFaceConfiguration? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CortexConfiguration? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomHostConfiguration? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretMapping? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingAdjustments? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateIntegrationRequest? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationDetailResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationList? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationDetailResponseVariant2? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GlobalWorkspaceAccess? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingMultiplier? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingMultiplierImage? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIConfigurationProviderAuthType? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIConfigurationWifIdentitySource? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicConfigurationProviderAuthType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicConfigurationWifIdentitySource? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureDeploymentConfig? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockConfigurationAwsAuthType? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SageMakerConfigurationVariant2? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexAIConfigurationVertexAuthType? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureAIConfigurationAzureAuthMode? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretMappingValueFormat? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequest? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestManagerType? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuthConfig? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfig? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfig? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfig? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureEntraAuthConfig? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureManagedAuthConfig? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfig? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfig? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfig? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfig? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateSecretReferenceRequest? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItem? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItemManagerType? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItemStatus? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceListItemObject? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponse? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseManagerType? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseStatus? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SecretReferenceDetailResponseObject? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAccessKeyAuthConfigAwsAuthType? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AwsServiceRoleAuthConfigAwsAuthType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureEntraAuthConfigAzureAuthMode? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureManagedAuthConfigAzureAuthMode? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureDefaultAuthConfigAzureAuthMode? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpTokenAuthConfigVaultAuthType? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationListStatus? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationListObject? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationModelsResponse? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationModel>? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationModel? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingConfig? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PricingConfigType? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PayAsYouGoPricing? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.TokenPricing? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelConfigurations? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelConfigurationsCustomHeaders? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateModelsRequest? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ModelUpdateRequest>? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelUpdateRequest? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationWorkspacesResponse? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationWorkspace>? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.IntegrationWorkspace? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateWorkspacesRequest? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceUpdateRequest? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Providers? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ProvidersStatus? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ProvidersObject? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VirtualKeys? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VirtualKeysStatus? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VirtualKeysObject? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Invite? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteRole2? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteStatus? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteList? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.InviteListObject? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Invite>? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.User? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserObject? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserRole? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserList? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UserListObject? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.User>? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMember? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberObject? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberOrgRole? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberRole? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberStatus? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberList? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceMemberListObject? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Workspace? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceDefaults? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceDefaultsObject? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceList? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceListObject? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Workspace>? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceWithUsers? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaults? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WorkspaceWithUsersDefaultsObject? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScimWorkspaceMapping? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ScimWorkspaceMappingRole? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Collection? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionStatus? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionDetails? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithDetails? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithDetailsVariant2? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ChildCollection? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithChildCollections? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CollectionWithChildCollectionsVariant2? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ChildCollection>? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Label? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateLabelRequest? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateLabelRequest? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateLabelResponse? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListLabelsResponse? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Label>? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptSummary? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptSummaryObject? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Prompt2? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPromptVersionStatus? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptVersionSummary? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptVersionSummaryStatus? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptVersionSummaryObject? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialSummary? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialSummaryStatus? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialSummaryObject? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartial? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialStatus? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialVersion? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialVersionPromptVersionStatus? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptPartialVersionObject? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLog? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLogRequest? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLogResponse? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CustomLogMetadata? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportListResponse? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportListResponseObject? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ExportItem>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportItem? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GenerationsFilterSchema? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportItemStatus? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportItemObject? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateExportResponse? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateExportResponseObject? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportTaskResponse? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ExportTaskResponseObject? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DownloadLogsResponse? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogObject? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogRequest? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogResponse? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnalyticsMetrics? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RequestResponseObject? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogRequestMethod? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.LogExportsRequestedDataItem? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectList? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AuditLogObjectListRecord>? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListRecord? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordMethod? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListRecordUserType? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AuditLogObjectListObject? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObject? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectType? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectStatus? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectCreationMode? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObjectRateLimit>? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectRateLimit? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectDefaults? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectObject? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectList? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ApiKeyObjectListObject? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ApiKeyObject>? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObject? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimit? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitType? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRateLimitUnit? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectDefaults? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicy? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObject? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimit? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitType? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRateLimitUnit? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectDefaults? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicy? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateApiKeyObjectRotationPolicyRotationPeriod? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RotateApiKeyRequest? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RotateApiKeyResponse? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptRenderResponse? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateGuardrailRequest? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateGuardrailRequestTarget? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailCheck? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActions? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateGuardrailRequest? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccess? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnSuccessFeedback? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnFail? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailActionsOnFailFeedback? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailCheckId? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JWTParameters? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ModelWhitelistParameters? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RegexMatchParameters? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SentenceCountParameters? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WordCountParameters? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CharacterCountParameters? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JSONSchemaParameters? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JSONKeysParameters? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsParameters? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ValidUrlsParameters? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsCodeParameters? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.WebhookParameters? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EndsWithParameters? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UppercaseParameters? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParameters? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllowedRequestTypesParameters? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.SydeGuardParameters? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AporiaParameters? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PillarScanParameters? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PatronusParameters? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PatronusCustomParameters? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyModerationParameters? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyLanguageParameters? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyPIIParameters? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MistralModerationParameters? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockGuardParameters? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PromptfooParameters? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParameters? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureContentSafetyParameters? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzurePIIParameters? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PANWPrismaParameters? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BasicParameters? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateGuardrailResponse? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateGuardrailResponse? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListGuardrailsResponse? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailSummary>? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailSummary? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailSummaryTarget? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailSummaryStatus? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailDetails? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GuardrailDetailsVariant2? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerMapping>? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerMapping? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerMappingRunOnItem>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerMappingRunOnItem? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsRequest? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2>? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkSyncMcpServerMappingsResponse? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpsertMcpServerMappingRequest? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UpsertMcpServerMappingRequestRunOnItem>? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpsertMcpServerMappingRequestRunOnItem? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpsertMcpServerMappingResponse? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.JSONKeysParametersOperator? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsParametersOperator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ContainsCodeParametersFormat? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RequiredMetadataKeysParametersOperator? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersAllowedType>? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersAllowedType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AllowedRequestTypesParametersBlockedType>? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllowedRequestTypesParametersBlockedType? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PillarScanParametersScanner>? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PillarScanParametersScanner? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyModerationParametersCategorie>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyModerationParametersCategorie? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyLanguageParametersLanguage? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PortkeyPIIParametersCategorie>? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyPIIParametersCategorie? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.MistralModerationParametersCategorie>? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.MistralModerationParametersCategorie? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParametersLanguageValues? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersPiiCategorie>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParametersPiiCategorie? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AcuvityScanParametersSecretsCategorie>? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AcuvityScanParametersSecretsCategorie? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AzureContentSafetyParametersCategorie>? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzureContentSafetyParametersCategorie? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AzurePIIParametersDomain? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockBatchJob? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIBatchJob? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BedrockBatchParams? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CommonBatchParams? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIBatchJobCompletionWindow? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OpenAIBatchJobEndpoint? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchJob? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchOptions? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexBatchJob? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.VertexBatchParams? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.Condition? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GroupBy? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequest? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Condition>? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GroupBy>? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestType? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequest? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequest? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestType? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestUnit? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateRateLimitsPolicyRequestTarget? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequest? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateRateLimitsPolicyRequestUnit? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicy? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyType? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyPeriodicReset? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyStatus? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ValueKeyUsage? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ValueKeyUsageStatus? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicy? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyType? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyUnit? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyStatus? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyTarget? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePolicyResponse? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyListResponse? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponse? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntity? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UsageLimitsPolicyEntityListResponse? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyListResponse? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponse? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegration? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegrationConfigurations? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegrationAuthType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpIntegrationTransport? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCreateResponse? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegration? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationAuthType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationTransport? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationType? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItem? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItemType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItemAuthType? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListItemTransport? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationListResponse? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegration? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationConfigurations? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationAuthType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpIntegrationTransport? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationWorkspaceItem? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesListResponse? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationWorkspaceItem>? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationWorkspacesLegacyResponse? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspaces? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItem? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilityItemType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCounts? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsTools? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsPrompts? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResources? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesCountsResourceTemplates? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListResponse? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpIntegrationCapabilityItem>? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilities? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationMetadata? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateMcpServer? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCreateResponse? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServer? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerMcpIntegrationDetails? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerListItem? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerListResponse? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerListItem>? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateMcpServer? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerTestResponse? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilityItem? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilityItemType? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCounts? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsTools? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsPrompts? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResources? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesCountsResourceTemplates? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListResponse? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerCapabilityItem>? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilities? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesBulkUpdateResponse? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessItem? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessItemConnectionStatus? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponse? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerUserAccessItem>? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessListResponseDefaultUserAccess? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccess? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessUserAcces? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerUserAccessBulkUpdateResponse? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerConnectionItem? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerConnectionsListResponse? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.McpServerConnectionItem>? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerConnectionDeleteResponse? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentAuthSettings? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentAuthSettingsInput? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentCredentials? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateDeploymentRequest? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateDeploymentRequestType? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequest? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequestType? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequestStatus? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateDeploymentRequestAuthSettings? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentCreateResponse? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentCreateResponseObject? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItem? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemStatus? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemConnectionStatus? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentListItemObject? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponse? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2AuthSettings? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.DeploymentDetailResponseVariant2Workspace>? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2Workspace? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponse? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseStatus? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseOutbound? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseOutboundStatus? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseInbound? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseInboundStatus? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeploymentPingResponseObject? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEgressAllowlistRequest? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateEgressAllowlistRequest? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EgressAllowlistEntry? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EgressAllowlistEntryStatus? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.EgressAllowlistEntryObject? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubject? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubjectType? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubjectDetails? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicySubjectDetailsType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTarget? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTarget? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTarget? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTargetDiscriminator? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTargetDiscriminatorType? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTargetType? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AccessPolicyMcpServerTargetTools?, global::System.Collections.Generic.IList<string>>? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTargetTools? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTargetType? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.AccessPolicyProviderTargetModels?, global::System.Collections.Generic.IList<string>>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTargetModels? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyRequest? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyRequestEffect? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject>? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateAccessPolicyRequest? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateAccessPolicyRequestEffect? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicy? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyEffect? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubjectDetails>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyStatus? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyObject? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItem? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItemEffect? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItemStatus? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyListItemObject? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCollectionsRequest? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutCollectionsRequest? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptRequest? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptRequest? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptVersionRequest? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptDefaultRequest? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptPartialRequest? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptPartialRequest? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptPartialDefaultRequest? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptCompletionRequest2? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptRenderRequest2? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob>? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateConfigRequest? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigRequest? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigRequestConfig? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateProvidersRequest? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutProvidersRequest? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequest? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestProvider? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysRequest? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysRequestDeploymentConfigItem? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminUsersRequest? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminUsersRequestRole? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequest? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUser? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesUsersRequestUserRole? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequest? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesUsersRequestRole? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequest? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequest? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutAdminWorkspacesRequestDefaults? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateScimWorkspacesRequest? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateScimWorkspacesRequestRole? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CustomLog, global::System.Collections.Generic.IList<global::Portkey.CustomLog>>? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CustomLog>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutLogsExportsRequest? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateLogsExportsRequest? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsSort? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListModelsOrder? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAssistantsOrder? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListInputItemsOrder? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListMessagesOrder? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunsOrder? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRunStepsOrder? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoresOrder? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoreFilesOrder? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListVectorStoreFilesFilter? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchOrder? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListFilesInVectorStoreBatchFilter? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetIntegrationsType? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesRole? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminUsersInvitesStatus? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminUsersRole? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminWorkspacesUsersRole? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAdminWorkspacesStatus? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesRole? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationsListType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpIntegrationCapabilitiesListType? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.McpServerCapabilitiesListType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetLogsPathFormat? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetLogsType? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAuditLogsMethod? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAuditLogsUserType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysType? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysSubType? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesStatus? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListUsageLimitsPoliciesType? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetUsageLimitsPolicyStatus? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListUsageLimitsPolicyEntitiesStatus? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesStatus? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesType? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesUnit? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListRateLimitsPoliciesTarget? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetRateLimitsPolicyStatus? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAccessPoliciesEffect? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderIncludeTotal? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListSecretReferencesManagerType? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsStatus? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsType? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateCollectionsResponse? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetCollectionsResponse? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.CollectionWithDetails>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptResponse? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptResponseObject? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListPromptsResponse? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptSummary>? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptResponse? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptPartialResponse? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdatePromptPartialResponse? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreatePromptCompletionResponse? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateChatCompletionResponse, global::Portkey.CreateCompletionResponse>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigsResponse? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigsResponseDataItem>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigsResponseDataItem? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateConfigResponse? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateConfigResponseData? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponse? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseData? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfig? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigRetry? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigCache? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigStrategy? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetConfigResponseDataConfigTarget>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetConfigResponseDataConfigTarget? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigResponse? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.UpdateConfigResponseData? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigVersionsResponse? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.ListConfigVersionsResponseDataItem>? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListConfigVersionsResponseDataItem? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetIntegrationsResponse? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetIntegrationsResponseObject? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.IntegrationList>? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateIntegrationsResponse? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetProvidersResponse? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetProvidersResponseObject? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.Providers>? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateProvidersResponse? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutProvidersResponse? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseObject? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse2? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponse2? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateVirtualKeysResponseData2? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponse3? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetVirtualKeysResponseData2? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysResponse2? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.PutVirtualKeysResponseData? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponse2? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteVirtualKeysResponseData? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAdminUsersInvitesResendResponse? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponse? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponseMapping? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetScimWorkspacesResponseMappingRole? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.DeleteScimWorkspacesResponse? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysResponse? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateKeysResponseObject? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyResponse? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateAccessPolicyResponseObject? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAccessPoliciesResponse? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListAccessPoliciesResponseObject? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AccessPolicyListItem>? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponse? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseSummary? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsResponseObject? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponse? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseSummary? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseDataPoint? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCostResponseObject? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponse? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseSummary? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsLatencyResponseObject? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponse? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseSummary? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsTokensResponseObject? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponse? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseSummary? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersResponseObject? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponse? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponse? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseSummary? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsResponseObject? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponse? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponse? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponse? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponse? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponse? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponse? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseSummary? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsSummaryCacheResponseObject? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponse? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseObject? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItem? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponse? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseObject? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderResponse? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderResponseObject? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsProviderResponseDataItem? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponse? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseObject? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponse? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponseObject? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMcpResponseDataItem>? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponseDataItem? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponse? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponseObject? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponseDataItem? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponse? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem>? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.GetModelPricingResponse? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListSecretReferencesResponse? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListSecretReferencesResponseObject? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponse? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateSecretReferenceResponseObject? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsResponse? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListDeploymentsResponseObject? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.DeploymentListItem>? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListEgressAllowlistResponse? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.ListEgressAllowlistResponseObject? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.EgressAllowlistEntry>? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEgressAllowlistEntryResponse? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.CreateEgressAllowlistEntryResponseObject? Type1776 { get; set; }

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
        public global::System.Collections.Generic.List<global::Portkey.AnthropicMessage>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AnthropicTool>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ModelCalculateOperation, global::Portkey.ModelValueReference>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.WorkspaceInvite>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Model11>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateCompletionResponseChoice>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessageContentPart>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCall>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FileSearchToolCallResult>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputContent>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Annotation>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageContentBlock>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionMessageToolCallChunk>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionRequestMessage>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTool>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionFunctions>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionResponseChoice>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprob>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionFunctionResponseChoice>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ChatCompletionTokenLogprobTopLogprob>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJob>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateChatCompletionStreamResponseChoice>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Image>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.InputContent>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateModerationResponseResult>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputItem>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.InputItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Includable>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OpenAIFile>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJobEvent>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningJobCheckpoint>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Embedding>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RerankDocument>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RerankResult>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OcrPage>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OcrPageImage>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionWord>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.TranscriptionSegment>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Coordinate>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputContent>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.FineTuningIntegration>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterFileOutputFile>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CodeInterpreterToolOutput>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ComputerToolCallSafetyCheck>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ReasoningItemSummaryItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OutputItem>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ItemResource>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitie>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ResponseModalitiesTextOnlyItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.Tool>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearch, global::Portkey.AssistantToolsFunction>>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateAssistantRequestToolResourcesFileSearchVectorStore>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.AssistantObject>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunToolCallObject>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequest>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.RunObject>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.SubmitToolOutputsRunRequestToolOutput>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.ThreadObject>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageContentTextObject>>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.MessageObjectAttachment>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.AssistantToolsCode, global::Portkey.AssistantToolsFileSearchTypeOnly>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageDeltaContentImageFileObject, global::Portkey.MessageDeltaContentTextObject, global::Portkey.MessageDeltaContentImageUrlObject>>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Portkey.CreateMessageRequestAttachment>? ListType80 { get; set; }
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