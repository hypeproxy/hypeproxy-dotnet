using System.Text.Json;
using System.Text.Json.Serialization;

namespace HypeProxy.Converters;

public class JsonStringListConverter : JsonConverter<IEnumerable<string>?>
{
    public override IEnumerable<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<string>? value, JsonSerializerOptions options)
    {
        writer.WriteRawValue(JsonSerializer.Serialize(value, new JsonSerializerOptions()));
    }
}