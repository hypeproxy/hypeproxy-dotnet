using System.ComponentModel;
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
    /// <summary>
    /// The username of the proxy.
    /// </summary>
    public string? Username { get; set; }
    
    /// <summary>
    /// The password of the proxy.
    /// </summary>
	public string? Password { get; set; }
    
    /// <summary>
    /// (Optional) The list of authorized IP addresses.
    /// </summary>
    public virtual IEnumerable<string>? AuthorizedIps { get; set; }
}

public partial class Credential
{
    /// <summary>
    /// The proxy associated with the credential
    /// </summary>
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Proxy Proxy { get; set; }
}