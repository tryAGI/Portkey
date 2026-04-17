#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.Item>
    {
        /// <inheritdoc />
        public override global::Portkey.Item Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("queries")) __score2++;
            if (__jsonProps.Contains("results")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pending_safety_checks")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("acknowledged_safety_checks")) __score4++;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("output.file_id")) __score4++;
            if (__jsonProps.Contains("output.image_url")) __score4++;
            if (__jsonProps.Contains("output.type")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("arguments")) __score6++;
            if (__jsonProps.Contains("call_id")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("call_id")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("output")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("summary")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
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

            global::Portkey.InputMessage? message1 = default;
            global::Portkey.OutputMessage? message2 = default;
            global::Portkey.FileSearchToolCall? fileSearchCall = default;
            global::Portkey.ComputerToolCall? computerCall = default;
            global::Portkey.ComputerToolCallOutput? computerCallOutput = default;
            global::Portkey.WebSearchToolCall? webSearchCall = default;
            global::Portkey.FunctionToolCall? functionCall = default;
            global::Portkey.FunctionToolCallOutput? functionCallOutput = default;
            global::Portkey.ReasoningItem? reasoning = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputMessage).Name}");
                        message1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.OutputMessage).Name}");
                        message2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FileSearchToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FileSearchToolCall).Name}");
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCall).Name}");
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCallOutput).Name}");
                        computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.WebSearchToolCall).Name}");
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCall).Name}");
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallOutput).Name}");
                        functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ReasoningItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ReasoningItem).Name}");
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message1 == null && message2 == null && fileSearchCall == null && computerCall == null && computerCallOutput == null && webSearchCall == null && functionCall == null && functionCallOutput == null && reasoning == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputMessage).Name}");
                    message1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.OutputMessage).Name}");
                    message2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FileSearchToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FileSearchToolCall).Name}");
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCall).Name}");
                    computerCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCallOutput).Name}");
                    computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.WebSearchToolCall).Name}");
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCall).Name}");
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallOutput).Name}");
                    functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ReasoningItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ReasoningItem).Name}");
                    reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.Item(
                message1,

                message2,

                fileSearchCall,

                computerCall,

                computerCallOutput,

                webSearchCall,

                functionCall,

                functionCallOutput,

                reasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message1!, typeInfo);
            }
            else if (value.IsMessage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message2!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
            }
            else if (value.IsComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCallOutput!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
        }
    }
}