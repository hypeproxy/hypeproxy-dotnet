using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Entities.Features;
using HypeProxy.Entities.Infrastructure;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Proxies;

/// <summary>
/// Defines a logical access to a proxy server.
/// <seealso cref="Credential"/>
/// </summary>
[TranspilationSource]
public partial class Proxy : BaseEntityWithPurchaseContext
{
    /// <summary>
    /// The remote entry point for the proxy.
    /// </summary>
    public string? RemoteEntrypoint { get; set; }
    
    /// <summary>
    /// The remote hostname for the proxy.
    /// </summary>
	public string? RemoteHostname { get; set; }
    
    /// <summary>
    /// The primary port for the proxy.
    /// </summary>
	public int Port { get; set; }

    /// <summary>
    /// (Optional) An alternative port for the proxy.
    /// </summary>
	public int? Port2 { get; set; }
}

public partial class Proxy
{
    /// <summary>
    /// The Id of the associated compute unit.
    /// </summary>
    [ForeignKey(nameof(ComputeUnit))]
    public Guid? ComputeUnitId { get; set; }
    
    /// <summary>
    /// The associated compute unit.
    /// </summary>
    [JsonIgnore]
    public virtual ComputeUnit? ComputeUnit { get; set; }

    /// <summary>
    /// The Id of the associated provider.
    /// </summary>
    [ForeignKey(nameof(Provider))]
    public Guid ProviderId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Provider Provider { get; set; }
    
    /// <summary>
    /// The Id of the associated credential.
    /// </summary>
    [ForeignKey(nameof(Credential))]
    public Guid CredentialId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Credential? Credential { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual IpRotation? IpRotation { get; set; }
}

public partial class Proxy
{
    /// <summary>
    /// A comment associated with the proxy.
    /// </summary>
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? Comment { get; set; }

    /// <summary>
    /// (Optional) The interface of the proxy. 
    /// </summary>
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? Interface { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? MainData { get; set; }
}