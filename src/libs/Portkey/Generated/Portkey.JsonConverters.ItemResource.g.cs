#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class ItemResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ItemResource>
    {
        /// <inheritdoc />
        public override global::Portkey.ItemResource Read(
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
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            var __score7 = 0;
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

            global::Portkey.InputMessageResource? inputMessage = default;
            global::Portkey.OutputMessage? message = default;
            global::Portkey.FileSearchToolCall? fileSearchCall = default;
            global::Portkey.ComputerToolCall? computerCall = default;
            global::Portkey.ComputerToolCallOutputResource? computerToolCallOutput = default;
            global::Portkey.WebSearchToolCall? webSearchCall = default;
            global::Portkey.FunctionToolCallResource? functionToolCall = default;
            global::Portkey.FunctionToolCallOutputResource? functionToolCallOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessageResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessageResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputMessageResource).Name}");
                        inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutputResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCallOutputResource).Name}");
                        computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallResource).Name}");
                        functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutputResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallOutputResource).Name}");
                        functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputMessage == null && message == null && fileSearchCall == null && computerCall == null && computerToolCallOutput == null && webSearchCall == null && functionToolCall == null && functionToolCallOutput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessageResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessageResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputMessageResource).Name}");
                    inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutputResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCallOutputResource).Name}");
                    computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallResource).Name}");
                    functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutputResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallOutputResource).Name}");
                    functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.ItemResource(
                inputMessage,

                message,

                fileSearchCall,

                computerCall,

                computerToolCallOutput,

                webSearchCall,

                functionToolCall,

                functionToolCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ItemResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessageResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessageResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputMessageResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage!.Value, typeInfo);
            }
            else if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
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
            else if (value.IsComputerToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCallOutputResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutput!.Value, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsFunctionToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall!.Value, typeInfo);
            }
            else if (value.IsFunctionToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCallOutputResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutput!.Value, typeInfo);
            }
        }
    }
}