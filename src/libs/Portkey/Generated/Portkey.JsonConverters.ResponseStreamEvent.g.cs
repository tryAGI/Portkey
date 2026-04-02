#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class ResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::Portkey.ResponseStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("delta")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("delta")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("output_index")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("code")) __score5++;
            if (__jsonProps.Contains("output_index")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score6++;
            if (__jsonProps.Contains("output_index")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score7++;
            if (__jsonProps.Contains("output_index")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score8++;
            if (__jsonProps.Contains("output_index")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("response")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content_index")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("output_index")) __score10++;
            if (__jsonProps.Contains("part")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("content_index")) __score11++;
            if (__jsonProps.Contains("item_id")) __score11++;
            if (__jsonProps.Contains("output_index")) __score11++;
            if (__jsonProps.Contains("part")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("response")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("code")) __score13++;
            if (__jsonProps.Contains("message")) __score13++;
            if (__jsonProps.Contains("param")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("item_id")) __score14++;
            if (__jsonProps.Contains("output_index")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("item_id")) __score15++;
            if (__jsonProps.Contains("output_index")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("item_id")) __score16++;
            if (__jsonProps.Contains("output_index")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("delta")) __score17++;
            if (__jsonProps.Contains("item_id")) __score17++;
            if (__jsonProps.Contains("output_index")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("arguments")) __score18++;
            if (__jsonProps.Contains("item_id")) __score18++;
            if (__jsonProps.Contains("output_index")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("response")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("response")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("item")) __score22++;
            if (__jsonProps.Contains("output_index")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("item")) __score23++;
            if (__jsonProps.Contains("output_index")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("content_index")) __score24++;
            if (__jsonProps.Contains("delta")) __score24++;
            if (__jsonProps.Contains("item_id")) __score24++;
            if (__jsonProps.Contains("output_index")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("content_index")) __score25++;
            if (__jsonProps.Contains("item_id")) __score25++;
            if (__jsonProps.Contains("output_index")) __score25++;
            if (__jsonProps.Contains("refusal")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("annotation")) __score26++;
            if (__jsonProps.Contains("annotation_index")) __score26++;
            if (__jsonProps.Contains("content_index")) __score26++;
            if (__jsonProps.Contains("item_id")) __score26++;
            if (__jsonProps.Contains("output_index")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("content_index")) __score27++;
            if (__jsonProps.Contains("delta")) __score27++;
            if (__jsonProps.Contains("item_id")) __score27++;
            if (__jsonProps.Contains("output_index")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("content_index")) __score28++;
            if (__jsonProps.Contains("item_id")) __score28++;
            if (__jsonProps.Contains("output_index")) __score28++;
            if (__jsonProps.Contains("text")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("item_id")) __score29++;
            if (__jsonProps.Contains("output_index")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("item_id")) __score30++;
            if (__jsonProps.Contains("output_index")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("item_id")) __score31++;
            if (__jsonProps.Contains("output_index")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }

            global::Portkey.ResponseAudioDeltaEvent? responseAudioDelta = default;
            global::Portkey.ResponseAudioDoneEvent? responseAudioDone = default;
            global::Portkey.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta = default;
            global::Portkey.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone = default;
            global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta = default;
            global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone = default;
            global::Portkey.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted = default;
            global::Portkey.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress = default;
            global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting = default;
            global::Portkey.ResponseCompletedEvent? responseCompleted = default;
            global::Portkey.ResponseContentPartAddedEvent? responseContentPartAdded = default;
            global::Portkey.ResponseContentPartDoneEvent? responseContentPartDone = default;
            global::Portkey.ResponseCreatedEvent? responseCreated = default;
            global::Portkey.ResponseErrorEvent? error = default;
            global::Portkey.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted = default;
            global::Portkey.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress = default;
            global::Portkey.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching = default;
            global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta = default;
            global::Portkey.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone = default;
            global::Portkey.ResponseInProgressEvent? responseInProgress = default;
            global::Portkey.ResponseFailedEvent? responseFailed = default;
            global::Portkey.ResponseIncompleteEvent? responseIncomplete = default;
            global::Portkey.ResponseOutputItemAddedEvent? responseOutputItemAdded = default;
            global::Portkey.ResponseOutputItemDoneEvent? responseOutputItemDone = default;
            global::Portkey.ResponseRefusalDeltaEvent? responseRefusalDelta = default;
            global::Portkey.ResponseRefusalDoneEvent? responseRefusalDone = default;
            global::Portkey.ResponseTextAnnotationDeltaEvent? responseOutputTextAnnotationAdded = default;
            global::Portkey.ResponseTextDeltaEvent? responseOutputTextDelta = default;
            global::Portkey.ResponseTextDoneEvent? responseOutputTextDone = default;
            global::Portkey.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            global::Portkey.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            global::Portkey.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioTranscriptDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioTranscriptDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallCompletedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallInProgressEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCompletedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseContentPartAddedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseContentPartDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCreatedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseErrorEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFileSearchCallCompletedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFileSearchCallInProgressEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFileSearchCallSearchingEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFunctionCallArgumentsDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseInProgressEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        responseFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFailedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseIncompleteEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseOutputItemAddedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseOutputItemDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseRefusalDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseRefusalDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseTextAnnotationDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 27)
                {
                    try
                    {
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseTextDeltaEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 28)
                {
                    try
                    {
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseTextDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 29)
                {
                    try
                    {
                        responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 30)
                {
                    try
                    {
                        responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 31)
                {
                    try
                    {
                        responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseAudioDelta == null && responseAudioDone == null && responseAudioTranscriptDelta == null && responseAudioTranscriptDone == null && responseCodeInterpreterCallCodeDelta == null && responseCodeInterpreterCallCodeDone == null && responseCodeInterpreterCallCompleted == null && responseCodeInterpreterCallInProgress == null && responseCodeInterpreterCallInterpreting == null && responseCompleted == null && responseContentPartAdded == null && responseContentPartDone == null && responseCreated == null && error == null && responseFileSearchCallCompleted == null && responseFileSearchCallInProgress == null && responseFileSearchCallSearching == null && responseFunctionCallArgumentsDelta == null && responseFunctionCallArgumentsDone == null && responseInProgress == null && responseFailed == null && responseIncomplete == null && responseOutputItemAdded == null && responseOutputItemDone == null && responseRefusalDelta == null && responseRefusalDone == null && responseOutputTextAnnotationAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseWebSearchCallCompleted == null && responseWebSearchCallInProgress == null && responseWebSearchCallSearching == null)
            {
                try
                {
                    responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioTranscriptDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseAudioTranscriptDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseContentPartAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseContentPartDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseCreatedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFileSearchCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFileSearchCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFileSearchCallSearchingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFunctionCallArgumentsDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseIncompleteEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseOutputItemAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseOutputItemDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseRefusalDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseRefusalDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseTextAnnotationDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.ResponseStreamEvent(
                responseAudioDelta,

                responseAudioDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseCodeInterpreterCallCodeDelta,

                responseCodeInterpreterCallCodeDone,

                responseCodeInterpreterCallCompleted,

                responseCodeInterpreterCallInProgress,

                responseCodeInterpreterCallInterpreting,

                responseCompleted,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                error,

                responseFileSearchCallCompleted,

                responseFileSearchCallInProgress,

                responseFileSearchCallSearching,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseInProgress,

                responseFailed,

                responseIncomplete,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseRefusalDelta,

                responseRefusalDone,

                responseOutputTextAnnotationAdded,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseWebSearchCallCompleted,

                responseWebSearchCallInProgress,

                responseWebSearchCallSearching
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponseAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeof(global::Portkey.ResponseAudioDeltaEvent), options);
            }
            else if (value.IsResponseAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeof(global::Portkey.ResponseAudioDoneEvent), options);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent), options);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeof(global::Portkey.ResponseAudioTranscriptDoneEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDelta, typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDone, typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCompleted, typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInProgress, typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInterpreting, typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent), options);
            }
            else if (value.IsResponseCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompleted, typeof(global::Portkey.ResponseCompletedEvent), options);
            }
            else if (value.IsResponseContentPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeof(global::Portkey.ResponseContentPartAddedEvent), options);
            }
            else if (value.IsResponseContentPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeof(global::Portkey.ResponseContentPartDoneEvent), options);
            }
            else if (value.IsResponseCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeof(global::Portkey.ResponseCreatedEvent), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::Portkey.ResponseErrorEvent), options);
            }
            else if (value.IsResponseFileSearchCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallCompleted, typeof(global::Portkey.ResponseFileSearchCallCompletedEvent), options);
            }
            else if (value.IsResponseFileSearchCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInProgress, typeof(global::Portkey.ResponseFileSearchCallInProgressEvent), options);
            }
            else if (value.IsResponseFileSearchCallSearching)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallSearching, typeof(global::Portkey.ResponseFileSearchCallSearchingEvent), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent), options);
            }
            else if (value.IsResponseInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInProgress, typeof(global::Portkey.ResponseInProgressEvent), options);
            }
            else if (value.IsResponseFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFailed, typeof(global::Portkey.ResponseFailedEvent), options);
            }
            else if (value.IsResponseIncomplete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseIncomplete, typeof(global::Portkey.ResponseIncompleteEvent), options);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeof(global::Portkey.ResponseOutputItemAddedEvent), options);
            }
            else if (value.IsResponseOutputItemDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeof(global::Portkey.ResponseOutputItemDoneEvent), options);
            }
            else if (value.IsResponseRefusalDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta, typeof(global::Portkey.ResponseRefusalDeltaEvent), options);
            }
            else if (value.IsResponseRefusalDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone, typeof(global::Portkey.ResponseRefusalDoneEvent), options);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded, typeof(global::Portkey.ResponseTextAnnotationDeltaEvent), options);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta, typeof(global::Portkey.ResponseTextDeltaEvent), options);
            }
            else if (value.IsResponseOutputTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone, typeof(global::Portkey.ResponseTextDoneEvent), options);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallCompleted, typeof(global::Portkey.ResponseWebSearchCallCompletedEvent), options);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInProgress, typeof(global::Portkey.ResponseWebSearchCallInProgressEvent), options);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallSearching, typeof(global::Portkey.ResponseWebSearchCallSearchingEvent), options);
            }
        }
    }
}