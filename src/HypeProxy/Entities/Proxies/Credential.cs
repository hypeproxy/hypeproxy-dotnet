using System.Text.Json.Serialization;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Proxies;

/// <summary>
/// Defines the way to connect to a <see cref="Proxy"/>.
/// </summary>
[TranspilationSource]
public partial class Credential : BaseEntityWithCustomFilter
{
    public string? Username { get; set; }
	public string? Password { get; set; }
    public virtual IEnumerable<string>? AuthorizedIps { get; set; }
}

public partial class Credential
{
    [JsonIgnore]
    public virtual Proxy Proxy { get; set; }
}
    
// [JsonConverter(typeof(AuthorizedIpsConverter))]
// public virtual ICollection<AuthorizedIp>? AuthorizedIps { get; set; }

// public IEnumerable<string>? AuthorizedIpsSex => AuthorizedIps?.Select(authorizedIp => authorizedIp.IpAddress);

// public class AuthorizedIpsConverter : JsonConverter
// {
//     public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
//     {
//         var authorizedIps = value as ICollection<AuthorizedIp>;
//         var ipAddresses = authorizedIps?.Select(a => a.IpAddress).ToArray();
//         serializer.Serialize(writer, ipAddresses);
//     }
//
//     public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) => 
//         serializer.Deserialize<string[]>(reader)?
//             .Select(ip => new AuthorizedIp { IpAddress = ip })
//             .ToList();
//
//     public override bool CanConvert(Type objectType) => objectType == typeof(ICollection<AuthorizedIp>);
// }