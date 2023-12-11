using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Infrastructure.Entities;
using HypeProxy.Infrastructure.Junctions;
using Tapper;

namespace HypeProxy.Entities;

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
}

public partial class Credential
{
    /// <summary>
    /// The proxy associated with the credential
    /// </summary>
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Proxy Proxy { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<CredentialAuthorizedIp>? CredentialAuthorizedIps { get; set; }
}

public partial class Credential
{
    /// <summary>
    /// (Optional) The list of authorized IP addresses.
    /// </summary>
    [NotMapped]
    public IEnumerable<string>? AuthorizedIps => CredentialAuthorizedIps?
        .Where(credentialAuthorizedIps => credentialAuthorizedIps.CredentialId == Id)
        .Select(credentialAuthorizedIps => credentialAuthorizedIps.AuthorizedIp);
}