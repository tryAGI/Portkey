#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.OutputItem>
    {
        /// <inheritdoc />
        public override global::Portkey.OutputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.OutputItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Portkey.OutputMessage? message = default;
            if (discriminator?.Type == global::Portkey.OutputItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.OutputMessage)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.FileSearchToolCall? fileSearchCall = default;
            if (discriminator?.Type == global::Portkey.OutputItemDiscriminatorType.FileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.FileSearchToolCall)}");
                fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.FunctionToolCall? functionCall = default;
            if (discriminator?.Type == global::Portkey.OutputItemDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.FunctionToolCall)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.WebSearchToolCall? webSearchCall = default;
            if (discriminator?.Type == global::Portkey.OutputItemDiscriminatorType.WebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.WebSearchToolCall)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ComputerToolCall? computerCall = default;
            if (discriminator?.Type == global::Portkey.OutputItemDiscriminatorType.ComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ComputerToolCall)}");
                computerCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ReasoningItem? reasoning = default;
            if (discriminator?.Type == global::Portkey.OutputItemDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ReasoningItem)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Portkey.OutputItem(
                discriminator?.Type,
                message,

                fileSearchCall,

                functionCall,

                webSearchCall,

                computerCall,

                reasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.OutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
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
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
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