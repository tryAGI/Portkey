#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class AssistantStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AssistantStreamEvent>
    {
        /// <inheritdoc />
        public override global::Portkey.AssistantStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Portkey.ThreadStreamEvent? thread = default;
            global::Portkey.RunStreamEvent? run = default;
            global::Portkey.RunStepStreamEvent? runStep = default;
            global::Portkey.MessageStreamEvent? message = default;
            global::Portkey.ErrorEvent? error = default;
            global::Portkey.DoneEvent? done = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ThreadStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ThreadStreamEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ThreadStreamEvent).Name}");
                        thread = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.RunStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.RunStreamEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.RunStreamEvent).Name}");
                        run = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.RunStepStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.RunStepStreamEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.RunStepStreamEvent).Name}");
                        runStep = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.MessageStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.MessageStreamEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.MessageStreamEvent).Name}");
                        message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ErrorEvent).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DoneEvent).Name}");
                        done = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (thread == null && run == null && runStep == null && message == null && error == null && done == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ThreadStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ThreadStreamEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ThreadStreamEvent).Name}");
                    thread = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.RunStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.RunStreamEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.RunStreamEvent).Name}");
                    run = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.RunStepStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.RunStepStreamEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.RunStepStreamEvent).Name}");
                    runStep = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.MessageStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.MessageStreamEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.MessageStreamEvent).Name}");
                    message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ErrorEvent).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DoneEvent).Name}");
                    done = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.AssistantStreamEvent(
                thread,

                run,

                runStep,

                message,

                error,

                done
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AssistantStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ThreadStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ThreadStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ThreadStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thread!.Value, typeInfo);
            }
            else if (value.IsRun)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.RunStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.RunStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.RunStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run!.Value, typeInfo);
            }
            else if (value.IsRunStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.RunStepStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.RunStepStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.RunStepStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStep!.Value, typeInfo);
            }
            else if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.MessageStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.MessageStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.MessageStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!.Value, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done!, typeInfo);
            }
        }
    }
}