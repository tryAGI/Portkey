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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Portkey.InputMessage? message1 = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.InputMessage)}");
                message1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.OutputMessage? message2 = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.OutputMessage)}");
                message2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.FileSearchToolCall? fileSearchCall = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.FileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.FileSearchToolCall)}");
                fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ComputerToolCall? computerCall = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.ComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ComputerToolCall)}");
                computerCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ComputerToolCallOutput? computerCallOutput = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.ComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ComputerToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ComputerToolCallOutput)}");
                computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.WebSearchToolCall? webSearchCall = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.WebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.WebSearchToolCall)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.FunctionToolCall? functionCall = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.FunctionToolCall)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.FunctionToolCallOutput? functionCallOutput = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.FunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.FunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.FunctionToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.FunctionToolCallOutput)}");
                functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.ReasoningItem? reasoning = default;
            if (discriminator?.Type == global::Portkey.ItemDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.ReasoningItem)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Portkey.Item(
                discriminator?.Type,
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