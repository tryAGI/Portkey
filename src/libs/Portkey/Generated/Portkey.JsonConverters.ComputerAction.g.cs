#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class ComputerActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ComputerAction>
    {
        /// <inheritdoc />
        public override global::Portkey.ComputerAction Read(
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
            if (__jsonProps.Contains("button")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("x")) __score0++;
            if (__jsonProps.Contains("y")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("x")) __score1++;
            if (__jsonProps.Contains("y")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("path")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("keys")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("x")) __score4++;
            if (__jsonProps.Contains("y")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("scroll_x")) __score6++;
            if (__jsonProps.Contains("scroll_y")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("x")) __score6++;
            if (__jsonProps.Contains("y")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("text")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
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

            global::Portkey.Click? click = default;
            global::Portkey.DoubleClick? doubleClick = default;
            global::Portkey.Drag? drag = default;
            global::Portkey.KeyPress? keyPress = default;
            global::Portkey.Move? move = default;
            global::Portkey.Screenshot? screenshot = default;
            global::Portkey.Scroll? scroll = default;
            global::Portkey.Type? type = default;
            global::Portkey.Wait? wait = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Click> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Click).Name}");
                        click = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DoubleClick> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DoubleClick).Name}");
                        doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Drag> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Drag).Name}");
                        drag = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.KeyPress> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.KeyPress).Name}");
                        keyPress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Move> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Move).Name}");
                        move = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Screenshot> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Screenshot).Name}");
                        screenshot = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Scroll> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Scroll).Name}");
                        scroll = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Type> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Type).Name}");
                        type = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Wait> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Wait).Name}");
                        wait = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (click == null && doubleClick == null && drag == null && keyPress == null && move == null && screenshot == null && scroll == null && type == null && wait == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Click> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Click).Name}");
                    click = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DoubleClick> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DoubleClick).Name}");
                    doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Drag> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Drag).Name}");
                    drag = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.KeyPress> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.KeyPress).Name}");
                    keyPress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Move> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Move).Name}");
                    move = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Screenshot> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Screenshot).Name}");
                    screenshot = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Scroll> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Scroll).Name}");
                    scroll = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Type> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Type).Name}");
                    type = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Wait> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Wait).Name}");
                    wait = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Portkey.ComputerAction(
                click,

                doubleClick,

                drag,

                keyPress,

                move,

                screenshot,

                scroll,

                type,

                wait
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ComputerAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Click?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Click).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Click!, typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DoubleClick?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DoubleClick).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DoubleClick!, typeInfo);
            }
            else if (value.IsDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Drag?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Drag).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Drag!, typeInfo);
            }
            else if (value.IsKeyPress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.KeyPress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.KeyPress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeyPress!, typeInfo);
            }
            else if (value.IsMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Move?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Move).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Move!, typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Screenshot?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Screenshot).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Screenshot!, typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Scroll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Scroll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scroll!, typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Type?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Type).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Type!, typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.Wait?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.Wait).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wait!, typeInfo);
            }
        }
    }
}