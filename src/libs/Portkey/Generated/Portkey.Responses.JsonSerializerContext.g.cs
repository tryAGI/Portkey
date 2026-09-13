
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolType), TypeInfoPropertyName = "FileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>), TypeInfoPropertyName = "OneOfComparisonFilterCompoundFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComparisonFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolRankingOptionsRanker), TypeInfoPropertyName = "FileSearchToolRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallType), TypeInfoPropertyName = "FileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallStatus), TypeInfoPropertyName = "FileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FileSearchToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputContent), TypeInfoPropertyName = "OutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Refusal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItem), TypeInfoPropertyName = "OutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItemDiscriminatorType), TypeInfoPropertyName = "OutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageType), TypeInfoPropertyName = "OutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageRole), TypeInfoPropertyName = "OutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageStatus), TypeInfoPropertyName = "OutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputTextType), TypeInfoPropertyName = "OutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Annotation), TypeInfoPropertyName = "Annotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Includable), TypeInfoPropertyName = "Includable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallType), TypeInfoPropertyName = "FunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallStatus), TypeInfoPropertyName = "FunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputType), TypeInfoPropertyName = "FunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputStatus), TypeInfoPropertyName = "FunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputResource), TypeInfoPropertyName = "FunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallResource), TypeInfoPropertyName = "FunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputContent), TypeInfoPropertyName = "InputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputFileType), TypeInfoPropertyName = "InputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageType), TypeInfoPropertyName = "InputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageDetail), TypeInfoPropertyName = "InputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItem), TypeInfoPropertyName = "InputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Item), TypeInfoPropertyName = "Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItemDiscriminatorType), TypeInfoPropertyName = "InputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageType), TypeInfoPropertyName = "InputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageRole), TypeInfoPropertyName = "InputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageStatus), TypeInfoPropertyName = "InputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageResource), TypeInfoPropertyName = "InputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputTextType), TypeInfoPropertyName = "InputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModelResponseProperties), TypeInfoPropertyName = "CreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateResponse), TypeInfoPropertyName = "CreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>), TypeInfoPropertyName = "OneOfStringIListInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Includable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Move))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MoveType), TypeInfoPropertyName = "MoveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoubleClick))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoubleClickType), TypeInfoPropertyName = "DoubleClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Drag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DragType), TypeInfoPropertyName = "DragType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Coordinate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Coordinate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageRole), TypeInfoPropertyName = "EasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>), TypeInfoPropertyName = "OneOfStringIListInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageType), TypeInfoPropertyName = "EasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Click))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickType), TypeInfoPropertyName = "ClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickButton), TypeInfoPropertyName = "ClickButton2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutputType), TypeInfoPropertyName = "CodeInterpreterFileOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterFileOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTextOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTextOutputType), TypeInfoPropertyName = "CodeInterpreterTextOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallType), TypeInfoPropertyName = "CodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallStatus), TypeInfoPropertyName = "CodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CodeInterpreterToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolOutput), TypeInfoPropertyName = "CodeInterpreterToolOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComparisonFilterType), TypeInfoPropertyName = "ComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, double?, bool?>), TypeInfoPropertyName = "OneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompoundFilterType), TypeInfoPropertyName = "CompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>), TypeInfoPropertyName = "OneOfComparisonFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerAction), TypeInfoPropertyName = "ComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.KeyPress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Screenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Scroll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Wait))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerScreenshotImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerScreenshotImageType), TypeInfoPropertyName = "ComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolType), TypeInfoPropertyName = "ComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolEnvironment), TypeInfoPropertyName = "ComputerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallType), TypeInfoPropertyName = "ComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ComputerToolCallSafetyCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallSafetyCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallStatus), TypeInfoPropertyName = "ComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputType), TypeInfoPropertyName = "ComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputStatus), TypeInfoPropertyName = "ComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputResource), TypeInfoPropertyName = "ComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Reasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningEffort), TypeInfoPropertyName = "ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningGenerateSummary), TypeInfoPropertyName = "ReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemType), TypeInfoPropertyName = "ReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemSummaryItemType), TypeInfoPropertyName = "ReasoningItemSummaryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemStatus), TypeInfoPropertyName = "ReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RefusalType), TypeInfoPropertyName = "RefusalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Response), TypeInfoPropertyName = "Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Object), TypeInfoPropertyName = "ResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Status), TypeInfoPropertyName = "ResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3IncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason), TypeInfoPropertyName = "ResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDeltaEventType), TypeInfoPropertyName = "ResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDoneEventType), TypeInfoPropertyName = "ResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType), TypeInfoPropertyName = "ResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDoneEventType), TypeInfoPropertyName = "ResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCompletedEventType), TypeInfoPropertyName = "ResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartAddedEventType), TypeInfoPropertyName = "ResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartDoneEventType), TypeInfoPropertyName = "ResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCreatedEventType), TypeInfoPropertyName = "ResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorCode), TypeInfoPropertyName = "ResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorEventType), TypeInfoPropertyName = "ResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFailedEventType), TypeInfoPropertyName = "ResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallCompletedEventType), TypeInfoPropertyName = "ResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallInProgressEventType), TypeInfoPropertyName = "ResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallSearchingEventType), TypeInfoPropertyName = "ResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseInProgressEventType), TypeInfoPropertyName = "ResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseIncompleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseIncompleteEventType), TypeInfoPropertyName = "ResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseItemListObject), TypeInfoPropertyName = "ResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResource), TypeInfoPropertyName = "ItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemAddedEventType), TypeInfoPropertyName = "ResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemDoneEventType), TypeInfoPropertyName = "ResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponsePropertiesText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatConfiguration), TypeInfoPropertyName = "TextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>), TypeInfoPropertyName = "OneOfToolChoiceOptionsToolChoiceTypesToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceOptions), TypeInfoPropertyName = "ToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponsePropertiesTruncation), TypeInfoPropertyName = "ResponsePropertiesTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDeltaEventType), TypeInfoPropertyName = "ResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDoneEventType), TypeInfoPropertyName = "ResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEvent), TypeInfoPropertyName = "ResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextAnnotationDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "ResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextAnnotationDeltaEventType), TypeInfoPropertyName = "ResponseTextAnnotationDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDeltaEventType), TypeInfoPropertyName = "ResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDoneEventType), TypeInfoPropertyName = "ResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallCompletedEventType), TypeInfoPropertyName = "ResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallInProgressEventType), TypeInfoPropertyName = "ResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallSearchingEventType), TypeInfoPropertyName = "ResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponses), TypeInfoPropertyName = "ModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponsesEnum), TypeInfoPropertyName = "ModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminatorType), TypeInfoPropertyName = "ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReferenceType), TypeInfoPropertyName = "ItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminatorType), TypeInfoPropertyName = "ItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.KeyPressType), TypeInfoPropertyName = "KeyPressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatJsonSchemaType), TypeInfoPropertyName = "TextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScreenshotType), TypeInfoPropertyName = "ScreenshotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScrollType), TypeInfoPropertyName = "ScrollType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WaitType), TypeInfoPropertyName = "WaitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchContextSize), TypeInfoPropertyName = "WebSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolType), TypeInfoPropertyName = "WebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>), TypeInfoPropertyName = "AllOfWebSearchLocationWebSearchToolUserLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolUserLocationType), TypeInfoPropertyName = "WebSearchToolUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallType), TypeInfoPropertyName = "WebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallStatus), TypeInfoPropertyName = "WebSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TypeType1), TypeInfoPropertyName = "TypeType12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UrlCitationType), TypeInfoPropertyName = "UrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceFunctionType), TypeInfoPropertyName = "ToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceTypesType), TypeInfoPropertyName = "ToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileCitationType), TypeInfoPropertyName = "FileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FilePathType), TypeInfoPropertyName = "FilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListInputItemsOrder), TypeInfoPropertyName = "ListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolType?), TypeInfoPropertyName = "NullableFileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>?), TypeInfoPropertyName = "NullableOneOfComparisonFilterCompoundFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolRankingOptionsRanker?), TypeInfoPropertyName = "NullableFileSearchToolRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallType?), TypeInfoPropertyName = "NullableFileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileSearchToolCallStatus?), TypeInfoPropertyName = "NullableFileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputContent?), TypeInfoPropertyName = "NullableOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItem?), TypeInfoPropertyName = "NullableOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputItemDiscriminatorType?), TypeInfoPropertyName = "NullableOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageType?), TypeInfoPropertyName = "NullableOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageRole?), TypeInfoPropertyName = "NullableOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputMessageStatus?), TypeInfoPropertyName = "NullableOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OutputTextType?), TypeInfoPropertyName = "NullableOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Annotation?), TypeInfoPropertyName = "NullableAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Includable?), TypeInfoPropertyName = "NullableIncludable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolType?), TypeInfoPropertyName = "NullableFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallType?), TypeInfoPropertyName = "NullableFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallStatus?), TypeInfoPropertyName = "NullableFunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputType?), TypeInfoPropertyName = "NullableFunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputStatus?), TypeInfoPropertyName = "NullableFunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallOutputResource?), TypeInfoPropertyName = "NullableFunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FunctionToolCallResource?), TypeInfoPropertyName = "NullableFunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputContent?), TypeInfoPropertyName = "NullableInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputFileType?), TypeInfoPropertyName = "NullableInputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageType?), TypeInfoPropertyName = "NullableInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputImageDetail?), TypeInfoPropertyName = "NullableInputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItem?), TypeInfoPropertyName = "NullableInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Item?), TypeInfoPropertyName = "NullableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputItemDiscriminatorType?), TypeInfoPropertyName = "NullableInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageType?), TypeInfoPropertyName = "NullableInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageRole?), TypeInfoPropertyName = "NullableInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageStatus?), TypeInfoPropertyName = "NullableInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputMessageResource?), TypeInfoPropertyName = "NullableInputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InputTextType?), TypeInfoPropertyName = "NullableInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateModelResponseProperties?), TypeInfoPropertyName = "NullableCreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateResponse?), TypeInfoPropertyName = "NullableCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>?), TypeInfoPropertyName = "NullableOneOfStringIListInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.MoveType?), TypeInfoPropertyName = "NullableMoveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DoubleClickType?), TypeInfoPropertyName = "NullableDoubleClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DragType?), TypeInfoPropertyName = "NullableDragType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageRole?), TypeInfoPropertyName = "NullableEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>?), TypeInfoPropertyName = "NullableOneOfStringIListInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EasyInputMessageType?), TypeInfoPropertyName = "NullableEasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickType?), TypeInfoPropertyName = "NullableClickType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ClickButton?), TypeInfoPropertyName = "NullableClickButton2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterFileOutputType?), TypeInfoPropertyName = "NullableCodeInterpreterFileOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterTextOutputType?), TypeInfoPropertyName = "NullableCodeInterpreterTextOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallType?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolCallStatus?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CodeInterpreterToolOutput?), TypeInfoPropertyName = "NullableCodeInterpreterToolOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComparisonFilterType?), TypeInfoPropertyName = "NullableComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CompoundFilterType?), TypeInfoPropertyName = "NullableCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>?), TypeInfoPropertyName = "NullableOneOfComparisonFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerAction?), TypeInfoPropertyName = "NullableComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerScreenshotImageType?), TypeInfoPropertyName = "NullableComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolType?), TypeInfoPropertyName = "NullableComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolEnvironment?), TypeInfoPropertyName = "NullableComputerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallType?), TypeInfoPropertyName = "NullableComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallStatus?), TypeInfoPropertyName = "NullableComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputType?), TypeInfoPropertyName = "NullableComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputStatus?), TypeInfoPropertyName = "NullableComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ComputerToolCallOutputResource?), TypeInfoPropertyName = "NullableComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningEffort?), TypeInfoPropertyName = "NullableReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningGenerateSummary?), TypeInfoPropertyName = "NullableReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemType?), TypeInfoPropertyName = "NullableReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemSummaryItemType?), TypeInfoPropertyName = "NullableReasoningItemSummaryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ReasoningItemStatus?), TypeInfoPropertyName = "NullableReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RefusalType?), TypeInfoPropertyName = "NullableRefusalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Response?), TypeInfoPropertyName = "NullableResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Object?), TypeInfoPropertyName = "NullableResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3Status?), TypeInfoPropertyName = "NullableResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason?), TypeInfoPropertyName = "NullableResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDeltaEventType?), TypeInfoPropertyName = "NullableResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioDoneEventType?), TypeInfoPropertyName = "NullableResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType?), TypeInfoPropertyName = "NullableResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseAudioTranscriptDoneEventType?), TypeInfoPropertyName = "NullableResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCompletedEventType?), TypeInfoPropertyName = "NullableResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartAddedEventType?), TypeInfoPropertyName = "NullableResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseContentPartDoneEventType?), TypeInfoPropertyName = "NullableResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseCreatedEventType?), TypeInfoPropertyName = "NullableResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorCode?), TypeInfoPropertyName = "NullableResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseErrorEventType?), TypeInfoPropertyName = "NullableResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFailedEventType?), TypeInfoPropertyName = "NullableResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFileSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType?), TypeInfoPropertyName = "NullableResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType?), TypeInfoPropertyName = "NullableResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseInProgressEventType?), TypeInfoPropertyName = "NullableResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseIncompleteEventType?), TypeInfoPropertyName = "NullableResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseItemListObject?), TypeInfoPropertyName = "NullableResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResource?), TypeInfoPropertyName = "NullableItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemAddedEventType?), TypeInfoPropertyName = "NullableResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseOutputItemDoneEventType?), TypeInfoPropertyName = "NullableResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatConfiguration?), TypeInfoPropertyName = "NullableTextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>?), TypeInfoPropertyName = "NullableOneOfToolChoiceOptionsToolChoiceTypesToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceOptions?), TypeInfoPropertyName = "NullableToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponsePropertiesTruncation?), TypeInfoPropertyName = "NullableResponsePropertiesTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDeltaEventType?), TypeInfoPropertyName = "NullableResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseRefusalDoneEventType?), TypeInfoPropertyName = "NullableResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEvent?), TypeInfoPropertyName = "NullableResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextAnnotationDeltaEventType?), TypeInfoPropertyName = "NullableResponseTextAnnotationDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDeltaEventType?), TypeInfoPropertyName = "NullableResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseTextDoneEventType?), TypeInfoPropertyName = "NullableResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ResponseWebSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponses?), TypeInfoPropertyName = "NullableModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ModelIdsResponsesEnum?), TypeInfoPropertyName = "NullableModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemDiscriminatorType?), TypeInfoPropertyName = "NullableItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemReferenceType?), TypeInfoPropertyName = "NullableItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ItemResourceDiscriminatorType?), TypeInfoPropertyName = "NullableItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.KeyPressType?), TypeInfoPropertyName = "NullableKeyPressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScreenshotType?), TypeInfoPropertyName = "NullableScreenshotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScrollType?), TypeInfoPropertyName = "NullableScrollType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WaitType?), TypeInfoPropertyName = "NullableWaitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchContextSize?), TypeInfoPropertyName = "NullableWebSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolType?), TypeInfoPropertyName = "NullableWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>?), TypeInfoPropertyName = "NullableAllOfWebSearchLocationWebSearchToolUserLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolUserLocationType?), TypeInfoPropertyName = "NullableWebSearchToolUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallType?), TypeInfoPropertyName = "NullableWebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WebSearchToolCallStatus?), TypeInfoPropertyName = "NullableWebSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TypeType1?), TypeInfoPropertyName = "NullableTypeType12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UrlCitationType?), TypeInfoPropertyName = "NullableUrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceFunctionType?), TypeInfoPropertyName = "NullableToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ToolChoiceTypesType?), TypeInfoPropertyName = "NullableToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FileCitationType?), TypeInfoPropertyName = "NullableFileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FilePathType?), TypeInfoPropertyName = "NullableFilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListInputItemsOrder?), TypeInfoPropertyName = "NullableListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FileSearchToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Includable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Coordinate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<global::Portkey.InputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CodeInterpreterFileOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CodeInterpreterToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OneOf<global::Portkey.ComparisonFilter, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ComputerToolCallSafetyCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ReasoningItemSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Tool>))]
    internal sealed partial class ResponsesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.OutputContentJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OutputItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.FunctionToolCallResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.InputMessageResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CreateResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.CodeInterpreterToolOutputJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerActionJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ComputerToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ResponseStreamEventJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.AnnotationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ModelIdsResponsesJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ItemResourceJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.TextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputItem>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.InputContent>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, object>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ToolChoiceOptions?, global::Portkey.ToolChoiceTypes, global::Portkey.ToolChoiceFunction>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.ComparisonFilter, global::Portkey.CompoundFilter>());
            options.Converters.Add(new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.WebSearchLocation, global::Portkey.WebSearchToolUserLocation>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
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
                    typeToConvert == typeof(global::Portkey.FileSearchToolType)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolType?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallType)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallType?)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.OutputMessageType)

                    || typeToConvert == typeof(global::Portkey.OutputMessageType?)

                    || typeToConvert == typeof(global::Portkey.OutputMessageRole)

                    || typeToConvert == typeof(global::Portkey.OutputMessageRole?)

                    || typeToConvert == typeof(global::Portkey.OutputMessageStatus)

                    || typeToConvert == typeof(global::Portkey.OutputMessageStatus?)

                    || typeToConvert == typeof(global::Portkey.OutputTextType)

                    || typeToConvert == typeof(global::Portkey.OutputTextType?)

                    || typeToConvert == typeof(global::Portkey.Includable)

                    || typeToConvert == typeof(global::Portkey.Includable?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolType)

                    || typeToConvert == typeof(global::Portkey.FunctionToolType?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallType)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallType?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus)

                    || typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus?)

                    || typeToConvert == typeof(global::Portkey.InputFileType)

                    || typeToConvert == typeof(global::Portkey.InputFileType?)

                    || typeToConvert == typeof(global::Portkey.InputImageType)

                    || typeToConvert == typeof(global::Portkey.InputImageType?)

                    || typeToConvert == typeof(global::Portkey.InputImageDetail)

                    || typeToConvert == typeof(global::Portkey.InputImageDetail?)

                    || typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.InputMessageType)

                    || typeToConvert == typeof(global::Portkey.InputMessageType?)

                    || typeToConvert == typeof(global::Portkey.InputMessageRole)

                    || typeToConvert == typeof(global::Portkey.InputMessageRole?)

                    || typeToConvert == typeof(global::Portkey.InputMessageStatus)

                    || typeToConvert == typeof(global::Portkey.InputMessageStatus?)

                    || typeToConvert == typeof(global::Portkey.InputTextType)

                    || typeToConvert == typeof(global::Portkey.InputTextType?)

                    || typeToConvert == typeof(global::Portkey.MoveType)

                    || typeToConvert == typeof(global::Portkey.MoveType?)

                    || typeToConvert == typeof(global::Portkey.DoubleClickType)

                    || typeToConvert == typeof(global::Portkey.DoubleClickType?)

                    || typeToConvert == typeof(global::Portkey.DragType)

                    || typeToConvert == typeof(global::Portkey.DragType?)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageRole)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageRole?)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageType)

                    || typeToConvert == typeof(global::Portkey.EasyInputMessageType?)

                    || typeToConvert == typeof(global::Portkey.ClickType)

                    || typeToConvert == typeof(global::Portkey.ClickType?)

                    || typeToConvert == typeof(global::Portkey.ClickButton)

                    || typeToConvert == typeof(global::Portkey.ClickButton?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType?)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.ComparisonFilterType)

                    || typeToConvert == typeof(global::Portkey.ComparisonFilterType?)

                    || typeToConvert == typeof(global::Portkey.CompoundFilterType)

                    || typeToConvert == typeof(global::Portkey.CompoundFilterType?)

                    || typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType)

                    || typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolType)

                    || typeToConvert == typeof(global::Portkey.ComputerToolType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolEnvironment)

                    || typeToConvert == typeof(global::Portkey.ComputerToolEnvironment?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallType)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus)

                    || typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus?)

                    || typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary)

                    || typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::Portkey.ReasoningEffort)

                    || typeToConvert == typeof(global::Portkey.ReasoningEffort?)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemType)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemType?)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType?)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemStatus)

                    || typeToConvert == typeof(global::Portkey.ReasoningItemStatus?)

                    || typeToConvert == typeof(global::Portkey.RefusalType)

                    || typeToConvert == typeof(global::Portkey.RefusalType?)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Object)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Object?)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Status)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3Status?)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason)

                    || typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseCreatedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseCreatedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorCode)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorCode?)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseErrorEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFailedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFailedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatTextType)

                    || typeToConvert == typeof(global::Portkey.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseItemListObject)

                    || typeToConvert == typeof(global::Portkey.ResponseItemListObject?)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation)

                    || typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation?)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum)

                    || typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum?)

                    || typeToConvert == typeof(global::Portkey.ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.ItemReferenceType)

                    || typeToConvert == typeof(global::Portkey.ItemReferenceType?)

                    || typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Portkey.KeyPressType)

                    || typeToConvert == typeof(global::Portkey.KeyPressType?)

                    || typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::Portkey.ScreenshotType)

                    || typeToConvert == typeof(global::Portkey.ScreenshotType?)

                    || typeToConvert == typeof(global::Portkey.ScrollType)

                    || typeToConvert == typeof(global::Portkey.ScrollType?)

                    || typeToConvert == typeof(global::Portkey.WaitType)

                    || typeToConvert == typeof(global::Portkey.WaitType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchContextSize)

                    || typeToConvert == typeof(global::Portkey.WebSearchContextSize?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolType)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallType)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallType?)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus)

                    || typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus?)

                    || typeToConvert == typeof(global::Portkey.TypeType1)

                    || typeToConvert == typeof(global::Portkey.TypeType1?)

                    || typeToConvert == typeof(global::Portkey.UrlCitationType)

                    || typeToConvert == typeof(global::Portkey.UrlCitationType?)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceOptions)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceTypesType)

                    || typeToConvert == typeof(global::Portkey.ToolChoiceTypesType?)

                    || typeToConvert == typeof(global::Portkey.FileCitationType)

                    || typeToConvert == typeof(global::Portkey.FileCitationType?)

                    || typeToConvert == typeof(global::Portkey.FilePathType)

                    || typeToConvert == typeof(global::Portkey.FilePathType?)

                    || typeToConvert == typeof(global::Portkey.ListInputItemsOrder)

                    || typeToConvert == typeof(global::Portkey.ListInputItemsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.FileSearchToolType))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolType?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolRankingOptionsRanker?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallType))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallType?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileSearchToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.FileSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.OutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputItemDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.OutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageType))
                {
                    return new global::Portkey.JsonConverters.OutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageType?))
                {
                    return new global::Portkey.JsonConverters.OutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageRole))
                {
                    return new global::Portkey.JsonConverters.OutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageRole?))
                {
                    return new global::Portkey.JsonConverters.OutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageStatus))
                {
                    return new global::Portkey.JsonConverters.OutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputMessageStatus?))
                {
                    return new global::Portkey.JsonConverters.OutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputTextType))
                {
                    return new global::Portkey.JsonConverters.OutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OutputTextType?))
                {
                    return new global::Portkey.JsonConverters.OutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.Includable))
                {
                    return new global::Portkey.JsonConverters.IncludableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.Includable?))
                {
                    return new global::Portkey.JsonConverters.IncludableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolType))
                {
                    return new global::Portkey.JsonConverters.FunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolType?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallType))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallType?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputType?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FunctionToolCallOutputStatus?))
                {
                    return new global::Portkey.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputFileType))
                {
                    return new global::Portkey.JsonConverters.InputFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputFileType?))
                {
                    return new global::Portkey.JsonConverters.InputFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageType))
                {
                    return new global::Portkey.JsonConverters.InputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageType?))
                {
                    return new global::Portkey.JsonConverters.InputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageDetail))
                {
                    return new global::Portkey.JsonConverters.InputImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputImageDetail?))
                {
                    return new global::Portkey.JsonConverters.InputImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.InputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputItemDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.InputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageType))
                {
                    return new global::Portkey.JsonConverters.InputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageType?))
                {
                    return new global::Portkey.JsonConverters.InputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageRole))
                {
                    return new global::Portkey.JsonConverters.InputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageRole?))
                {
                    return new global::Portkey.JsonConverters.InputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageStatus))
                {
                    return new global::Portkey.JsonConverters.InputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputMessageStatus?))
                {
                    return new global::Portkey.JsonConverters.InputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputTextType))
                {
                    return new global::Portkey.JsonConverters.InputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InputTextType?))
                {
                    return new global::Portkey.JsonConverters.InputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MoveType))
                {
                    return new global::Portkey.JsonConverters.MoveTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.MoveType?))
                {
                    return new global::Portkey.JsonConverters.MoveTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoubleClickType))
                {
                    return new global::Portkey.JsonConverters.DoubleClickTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DoubleClickType?))
                {
                    return new global::Portkey.JsonConverters.DoubleClickTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DragType))
                {
                    return new global::Portkey.JsonConverters.DragTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DragType?))
                {
                    return new global::Portkey.JsonConverters.DragTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageRole))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageRole?))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageType))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EasyInputMessageType?))
                {
                    return new global::Portkey.JsonConverters.EasyInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickType))
                {
                    return new global::Portkey.JsonConverters.ClickTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickType?))
                {
                    return new global::Portkey.JsonConverters.ClickTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickButton))
                {
                    return new global::Portkey.JsonConverters.ClickButtonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ClickButton?))
                {
                    return new global::Portkey.JsonConverters.ClickButtonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterFileOutputType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterTextOutputType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallType?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CodeInterpreterToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComparisonFilterType))
                {
                    return new global::Portkey.JsonConverters.ComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComparisonFilterType?))
                {
                    return new global::Portkey.JsonConverters.ComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CompoundFilterType))
                {
                    return new global::Portkey.JsonConverters.CompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CompoundFilterType?))
                {
                    return new global::Portkey.JsonConverters.CompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType))
                {
                    return new global::Portkey.JsonConverters.ComputerScreenshotImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerScreenshotImageType?))
                {
                    return new global::Portkey.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolType))
                {
                    return new global::Portkey.JsonConverters.ComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolType?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolEnvironment))
                {
                    return new global::Portkey.JsonConverters.ComputerToolEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolEnvironment?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallType))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallType?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputType?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ComputerToolCallOutputStatus?))
                {
                    return new global::Portkey.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary))
                {
                    return new global::Portkey.JsonConverters.ReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningGenerateSummary?))
                {
                    return new global::Portkey.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningEffort))
                {
                    return new global::Portkey.JsonConverters.ReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningEffort?))
                {
                    return new global::Portkey.JsonConverters.ReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemType))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemType?))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemSummaryItemType?))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemStatus))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ReasoningItemStatus?))
                {
                    return new global::Portkey.JsonConverters.ReasoningItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RefusalType))
                {
                    return new global::Portkey.JsonConverters.RefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RefusalType?))
                {
                    return new global::Portkey.JsonConverters.RefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Object))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Object?))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Status))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3Status?))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseVariant3IncompleteDetailsReason?))
                {
                    return new global::Portkey.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseAudioTranscriptDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartAddedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseContentPartDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCreatedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseCreatedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorCode))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorCode?))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseErrorEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFailedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFailedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFileSearchCallSearchingEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatJsonObjectType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatTextType))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFormatTextType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseIncompleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseIncompleteEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseItemListObject))
                {
                    return new global::Portkey.JsonConverters.ResponseItemListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseItemListObject?))
                {
                    return new global::Portkey.JsonConverters.ResponseItemListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemAddedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseOutputItemDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation))
                {
                    return new global::Portkey.JsonConverters.ResponsePropertiesTruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponsePropertiesTruncation?))
                {
                    return new global::Portkey.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseRefusalDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseStreamEventDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextAnnotationDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDeltaEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseTextDoneEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallCompletedEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallInProgressEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ResponseWebSearchCallSearchingEventType?))
                {
                    return new global::Portkey.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum))
                {
                    return new global::Portkey.JsonConverters.ModelIdsResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ModelIdsResponsesEnum?))
                {
                    return new global::Portkey.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemReferenceType))
                {
                    return new global::Portkey.JsonConverters.ItemReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemReferenceType?))
                {
                    return new global::Portkey.JsonConverters.ItemReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType))
                {
                    return new global::Portkey.JsonConverters.ItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ItemResourceDiscriminatorType?))
                {
                    return new global::Portkey.JsonConverters.ItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.KeyPressType))
                {
                    return new global::Portkey.JsonConverters.KeyPressTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.KeyPressType?))
                {
                    return new global::Portkey.JsonConverters.KeyPressTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType))
                {
                    return new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TextResponseFormatJsonSchemaType?))
                {
                    return new global::Portkey.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScreenshotType))
                {
                    return new global::Portkey.JsonConverters.ScreenshotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScreenshotType?))
                {
                    return new global::Portkey.JsonConverters.ScreenshotTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScrollType))
                {
                    return new global::Portkey.JsonConverters.ScrollTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScrollType?))
                {
                    return new global::Portkey.JsonConverters.ScrollTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WaitType))
                {
                    return new global::Portkey.JsonConverters.WaitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WaitType?))
                {
                    return new global::Portkey.JsonConverters.WaitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchContextSize))
                {
                    return new global::Portkey.JsonConverters.WebSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchContextSize?))
                {
                    return new global::Portkey.JsonConverters.WebSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolType))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolType?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolUserLocationType?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallType))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallType?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WebSearchToolCallStatus?))
                {
                    return new global::Portkey.JsonConverters.WebSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TypeType1))
                {
                    return new global::Portkey.JsonConverters.TypeType1JsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.TypeType1?))
                {
                    return new global::Portkey.JsonConverters.TypeType1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UrlCitationType))
                {
                    return new global::Portkey.JsonConverters.UrlCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UrlCitationType?))
                {
                    return new global::Portkey.JsonConverters.UrlCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceFunctionType?))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceOptions))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceOptions?))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceTypesType))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ToolChoiceTypesType?))
                {
                    return new global::Portkey.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileCitationType))
                {
                    return new global::Portkey.JsonConverters.FileCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FileCitationType?))
                {
                    return new global::Portkey.JsonConverters.FileCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FilePathType))
                {
                    return new global::Portkey.JsonConverters.FilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FilePathType?))
                {
                    return new global::Portkey.JsonConverters.FilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListInputItemsOrder))
                {
                    return new global::Portkey.JsonConverters.ListInputItemsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListInputItemsOrder?))
                {
                    return new global::Portkey.JsonConverters.ListInputItemsOrderNullableJsonConverter();
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
                    0 => new ResponsesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}