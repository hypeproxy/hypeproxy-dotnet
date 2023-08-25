using System.Text.Json.Serialization;
using HypeProxy.Converters;
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
	
	// public bool IsIpAuthenticationEnabled { get; set; }
	
    // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    // [JsonConverter(typeof(JsonStringListConverter))]
    // [JsonConverter(typeof(AuthorizedIpConverter))]
    public virtual ICollection<AuthorizedIp>? AuthorizedIps { get; set; }
}

public partial class Credential
{
    [JsonIgnore]
    public virtual Proxy Proxy { get; set; }
}