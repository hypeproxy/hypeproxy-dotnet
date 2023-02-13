using System.Text.Json;
using System.Text.Json.Serialization;
using HypeProxy.Errors;

namespace HypeProxy.Converters;

public class ApiErrorCodeConverter : JsonConverter<ApiErrorCode>
{
    public override ApiErrorCode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();

    public override void Write(Utf8JsonWriter writer, ApiErrorCode value, JsonSerializerOptions options) => writer.WriteStringValue(value.GetValue());
}