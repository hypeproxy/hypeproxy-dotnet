using System.Text.Json;
using System.Text.Json.Serialization;
using HypeProxy.Responses.Base;

namespace HypeProxy.Converters;

[Obsolete]
public class ApiErrorCodeConverter : JsonConverter<ApiErrorCode>
{
    public override ApiErrorCode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

    public override void Write(Utf8JsonWriter writer, ApiErrorCode value, JsonSerializerOptions options) => writer.WriteStringValue((string)value);
}