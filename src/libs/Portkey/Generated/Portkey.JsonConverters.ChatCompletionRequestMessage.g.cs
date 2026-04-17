#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ChatCompletionRequestMessage>
    {
        /// <inheritdoc />
        public override global::Portkey.ChatCompletionRequestMessage Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("function_call")) __score3++;
            if (__jsonProps.Contains("function_call.arguments")) __score3++;
            if (__jsonProps.Contains("function_call.name")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_calls")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            if (__jsonProps.Contains("tool_call_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("role")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Portkey.ChatCompletionRequestSystemMessage? systemMessage = default;
            global::Portkey.ChatCompletionRequestDeveloperMessage? developerMessage = default;
            global::Portkey.ChatCompletionRequestUserMessage? userMessage = default;
            global::Portkey.ChatCompletionRequestAssistantMessage? assistantMessage = default;
            global::Portkey.ChatCompletionRequestToolMessage? toolMessage = default;
            global::Portkey.ChatCompletionRequestFunctionMessage? functionMessage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestSystemMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestSystemMessage).Name}");
                        systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestDeveloperMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestDeveloperMessage).Name}");
                        developerMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestUserMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestUserMessage).Name}");
                        userMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestAssistantMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestAssistantMessage).Name}");
                        assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestToolMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestToolMessage).Name}");
                        toolMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestFunctionMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestFunctionMessage).Name}");
                        functionMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (systemMessage == null && developerMessage == null && userMessage == null && assistantMessage == null && toolMessage == null && functionMessage == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestSystemMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestSystemMessage).Name}");
                    systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestDeveloperMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestDeveloperMessage).Name}");
                    developerMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestUserMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestUserMessage).Name}");
                    userMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestAssistantMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestAssistantMessage).Name}");
                    assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestToolMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestToolMessage).Name}");
                    toolMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestFunctionMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestFunctionMessage).Name}");
                    functionMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.ChatCompletionRequestMessage(
                systemMessage,

                developerMessage,

                userMessage,

                assistantMessage,

                toolMessage,

                functionMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ChatCompletionRequestMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage!, typeInfo);
            }
            else if (value.IsDeveloperMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestDeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestDeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeveloperMessage!, typeInfo);
            }
            else if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage!, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage!, typeInfo);
            }
            else if (value.IsToolMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolMessage!, typeInfo);
            }
            else if (value.IsFunctionMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ChatCompletionRequestFunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ChatCompletionRequestFunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionMessage!, typeInfo);
            }
        }
    }
}