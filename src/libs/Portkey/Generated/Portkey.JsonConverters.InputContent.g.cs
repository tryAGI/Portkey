#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class InputContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.InputContent>
    {
        /// <inheritdoc />
        public override global::Portkey.InputContent Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("detail")) __score1++;
            if (__jsonProps.Contains("file_id")) __score1++;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_data")) __score2++;
            if (__jsonProps.Contains("file_id")) __score2++;
            if (__jsonProps.Contains("filename")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Portkey.InputText? textInput = default;
            global::Portkey.InputImage? imageInput = default;
            global::Portkey.InputFile? fileInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputText).Name}");
                        textInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputImage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputImage).Name}");
                        imageInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputFile).Name}");
                        fileInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textInput == null && imageInput == null && fileInput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputText).Name}");
                    textInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputImage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputImage).Name}");
                    imageInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputFile).Name}");
                    fileInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.InputContent(
                textInput,

                imageInput,

                fileInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.InputContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextInput!, typeInfo);
            }
            else if (value.IsImageInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageInput!, typeInfo);
            }
            else if (value.IsFileInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.InputFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.InputFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileInput!, typeInfo);
            }
        }
    }
}