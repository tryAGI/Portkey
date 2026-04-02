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
                        click = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Click>(__rawJson, options);
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
                        doubleClick = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.DoubleClick>(__rawJson, options);
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
                        drag = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Drag>(__rawJson, options);
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
                        keyPress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.KeyPress>(__rawJson, options);
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
                        move = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Move>(__rawJson, options);
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
                        screenshot = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Screenshot>(__rawJson, options);
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
                        scroll = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Scroll>(__rawJson, options);
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
                        type = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Type>(__rawJson, options);
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
                        wait = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Wait>(__rawJson, options);
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
                    click = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Click>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    doubleClick = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.DoubleClick>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    drag = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Drag>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    keyPress = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.KeyPress>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    move = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Move>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    screenshot = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Screenshot>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    scroll = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Scroll>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    type = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Type>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    wait = global::System.Text.Json.JsonSerializer.Deserialize<global::Portkey.Wait>(__rawJson, options);
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

            if (value.IsClick)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Click, typeof(global::Portkey.Click), options);
            }
            else if (value.IsDoubleClick)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DoubleClick, typeof(global::Portkey.DoubleClick), options);
            }
            else if (value.IsDrag)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Drag, typeof(global::Portkey.Drag), options);
            }
            else if (value.IsKeyPress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeyPress, typeof(global::Portkey.KeyPress), options);
            }
            else if (value.IsMove)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Move, typeof(global::Portkey.Move), options);
            }
            else if (value.IsScreenshot)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Screenshot, typeof(global::Portkey.Screenshot), options);
            }
            else if (value.IsScroll)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scroll, typeof(global::Portkey.Scroll), options);
            }
            else if (value.IsType)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Type, typeof(global::Portkey.Type), options);
            }
            else if (value.IsWait)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wait, typeof(global::Portkey.Wait), options);
            }
        }
    }
}