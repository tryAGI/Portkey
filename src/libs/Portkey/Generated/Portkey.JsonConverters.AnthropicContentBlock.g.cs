#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AnthropicContentBlock>
    {
        /// <inheritdoc />
        public override global::Portkey.AnthropicContentBlock Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("source.data")) __score1++;
            if (__jsonProps.Contains("source.media_type")) __score1++;
            if (__jsonProps.Contains("source.type")) __score1++;
            if (__jsonProps.Contains("source.url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("citations")) __score2++;
            if (__jsonProps.Contains("citations.enabled")) __score2++;
            if (__jsonProps.Contains("context")) __score2++;
            if (__jsonProps.Contains("source")) __score2++;
            if (__jsonProps.Contains("source.data")) __score2++;
            if (__jsonProps.Contains("source.media_type")) __score2++;
            if (__jsonProps.Contains("source.text")) __score2++;
            if (__jsonProps.Contains("source.type")) __score2++;
            if (__jsonProps.Contains("source.url")) __score2++;
            if (__jsonProps.Contains("title")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("input")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("is_error")) __score4++;
            if (__jsonProps.Contains("tool_use_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("signature")) __score5++;
            if (__jsonProps.Contains("thinking")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Portkey.AnthropicTextContent? text = default;
            global::Portkey.AnthropicImageContent? image = default;
            global::Portkey.AnthropicDocumentContent? document = default;
            global::Portkey.AnthropicToolUseContent? toolUse = default;
            global::Portkey.AnthropicToolResultContent? toolResult = default;
            global::Portkey.AnthropicThinkingContent? thinking = default;
            global::Portkey.AnthropicRedactedThinkingContent? redactedThinking = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicTextContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicTextContent).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicImageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicImageContent).Name}");
                        image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicDocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicDocumentContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicDocumentContent).Name}");
                        document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicToolUseContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicToolUseContent).Name}");
                        toolUse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicToolResultContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicToolResultContent).Name}");
                        toolResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicThinkingContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicThinkingContent).Name}");
                        thinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicRedactedThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicRedactedThinkingContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicRedactedThinkingContent).Name}");
                        redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicTextContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicTextContent).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicImageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicImageContent).Name}");
                    image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicDocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicDocumentContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicDocumentContent).Name}");
                    document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicToolUseContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicToolUseContent).Name}");
                    toolUse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicToolResultContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicToolResultContent).Name}");
                    toolResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicThinkingContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicThinkingContent).Name}");
                    thinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (text == null && image == null && document == null && toolUse == null && toolResult == null && thinking == null && redactedThinking == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicRedactedThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicRedactedThinkingContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicRedactedThinkingContent).Name}");
                    redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Portkey.AnthropicContentBlock(
                text,

                image,

                document,

                toolUse,

                toolResult,

                thinking,

                redactedThinking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AnthropicContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicTextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicTextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImage(), typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicDocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicDocumentContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicDocumentContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDocument(), typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicToolUseContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicToolUseContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickToolUse(), typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickToolResult(), typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicThinkingContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicThinkingContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickThinking(), typeInfo);
            }
            else if (value.IsRedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AnthropicRedactedThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AnthropicRedactedThinkingContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AnthropicRedactedThinkingContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRedactedThinking(), typeInfo);
            }
        }
    }
}