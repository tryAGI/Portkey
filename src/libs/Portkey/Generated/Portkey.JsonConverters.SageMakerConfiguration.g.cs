#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class SageMakerConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.SageMakerConfiguration>
    {
        /// <inheritdoc />
        public override global::Portkey.SageMakerConfiguration Read(
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
            if (__jsonProps.Contains("aws_access_key_id")) __score0++;
            if (__jsonProps.Contains("aws_auth_type")) __score0++;
            if (__jsonProps.Contains("aws_external_id")) __score0++;
            if (__jsonProps.Contains("aws_region")) __score0++;
            if (__jsonProps.Contains("aws_role_arn")) __score0++;
            if (__jsonProps.Contains("aws_secret_access_key")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("amzn_sagemaker_custom_attributes")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_enable_explanations")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_inference_component")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_inference_id")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_model_name")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_session_id")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_target_container_hostname")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_target_model")) __score1++;
            if (__jsonProps.Contains("amzn_sagemaker_target_variant")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Portkey.BedrockConfiguration? bedrock = default;
            global::Portkey.SageMakerConfigurationVariant2? sageMakerConfigurationVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.BedrockConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.BedrockConfiguration> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.BedrockConfiguration).Name}");
                        bedrock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.SageMakerConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.SageMakerConfigurationVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.SageMakerConfigurationVariant2).Name}");
                        sageMakerConfigurationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (bedrock == null && sageMakerConfigurationVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.BedrockConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.BedrockConfiguration> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.BedrockConfiguration).Name}");
                    bedrock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (bedrock == null && sageMakerConfigurationVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.SageMakerConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.SageMakerConfigurationVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.SageMakerConfigurationVariant2).Name}");
                    sageMakerConfigurationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.SageMakerConfiguration(
                bedrock,

                sageMakerConfigurationVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.SageMakerConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.BedrockConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.BedrockConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.BedrockConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bedrock!, typeInfo);
            }
            else if (value.IsSageMakerConfigurationVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.SageMakerConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.SageMakerConfigurationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.SageMakerConfigurationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SageMakerConfigurationVariant2!, typeInfo);
            }
        }
    }
}