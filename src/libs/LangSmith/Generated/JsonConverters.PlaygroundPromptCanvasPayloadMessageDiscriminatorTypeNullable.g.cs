#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlaygroundPromptCanvasPayloadMessageDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
