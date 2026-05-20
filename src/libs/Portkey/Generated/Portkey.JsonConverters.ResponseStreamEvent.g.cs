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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Portkey.ResponseAudioDeltaEvent? responseAudioDelta = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseAudioDeltaEvent)}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseAudioDoneEvent? responseAudioDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseAudioDoneEvent)}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseAudioTranscriptDeltaEvent)}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseAudioTranscriptDoneEvent)}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent)}");
                responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent)}");
                responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent)}");
                responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent)}");
                responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent)}");
                responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCompletedEvent? responseCompleted = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCompletedEvent)}");
                responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseContentPartAddedEvent? responseContentPartAdded = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseContentPartAddedEvent)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseContentPartDoneEvent? responseContentPartDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseContentPartDoneEvent)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseCreatedEvent? responseCreated = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseCreatedEvent)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseErrorEvent? error = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFileSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseFileSearchCallCompletedEvent)}");
                responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFileSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseFileSearchCallInProgressEvent)}");
                responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFileSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseFileSearchCallSearchingEvent)}");
                responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseInProgressEvent? responseInProgress = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseInProgressEvent)}");
                responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseFailedEvent? responseFailed = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseFailedEvent)}");
                responseFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseIncompleteEvent? responseIncomplete = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseIncompleteEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseIncompleteEvent)}");
                responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseOutputItemAddedEvent? responseOutputItemAdded = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseOutputItemAddedEvent)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseOutputItemDoneEvent? responseOutputItemDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseOutputItemDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseOutputItemDoneEvent)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseRefusalDeltaEvent? responseRefusalDelta = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseRefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseRefusalDeltaEvent)}");
                responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseRefusalDoneEvent? responseRefusalDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseRefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseRefusalDoneEvent)}");
                responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseTextAnnotationDeltaEvent? responseOutputTextAnnotationAdded = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseTextAnnotationDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseTextAnnotationDeltaEvent)}");
                responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseTextDeltaEvent? responseOutputTextDelta = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseTextDeltaEvent)}");
                responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseTextDoneEvent? responseOutputTextDone = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseTextDoneEvent)}");
                responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseWebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseWebSearchCallCompletedEvent)}");
                responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseWebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseWebSearchCallInProgressEvent)}");
                responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
            if (discriminator?.Type == global::Portkey.ResponseStreamEventDiscriminatorType.ResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseWebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ResponseWebSearchCallSearchingEvent)}");
                responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Portkey.ResponseStreamEvent(
                discriminator?.Type,
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseAudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta!, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioTranscriptDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseAudioTranscriptDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseAudioTranscriptDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseAudioTranscriptDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDelta!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDone!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCodeInterpreterCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCompleted!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCodeInterpreterCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInProgress!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCodeInterpreterCallInterpretingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInterpreting!, typeInfo);
            }
            else if (value.IsResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompleted!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseContentPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseContentPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseContentPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseContentPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFileSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseFileSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallCompleted!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFileSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseFileSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInProgress!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFileSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseFileSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallSearching!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFunctionCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFunctionCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseFunctionCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInProgress!, typeInfo);
            }
            else if (value.IsResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFailed!, typeInfo);
            }
            else if (value.IsResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseIncompleteEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseIncompleteEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseIncomplete!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseOutputItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseOutputItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseOutputItemDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseOutputItemDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseRefusalDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseRefusalDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta!, typeInfo);
            }
            else if (value.IsResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseRefusalDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseRefusalDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone!, typeInfo);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseTextAnnotationDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseTextAnnotationDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded!, typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta!, typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseWebSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseWebSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallCompleted!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseWebSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseWebSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInProgress!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseWebSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseWebSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallSearching!, typeInfo);
            }
        }
    }
}