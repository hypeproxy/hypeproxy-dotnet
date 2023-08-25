using System.Text.Json;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Proxies;

namespace HypeProxy.Converters;

public class AuthorizedIpConverter :  JsonConverter<ICollection<AuthorizedIp>>
{
    public override ICollection<AuthorizedIp>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var ipAddresses = JsonSerializer.Deserialize<List<string>>(ref reader, options);
        return ipAddresses?.Select(ip => new AuthorizedIp { IpAddress = ip }).ToList();
    }

    public override void Write(Utf8JsonWriter writer, ICollection<AuthorizedIp> value, JsonSerializerOptions options)
    {
        var ipAddresses = value.Select(ip => ip.IpAddress).ToList();
        JsonSerializer.Serialize(writer, ipAddresses, options);
    }
}