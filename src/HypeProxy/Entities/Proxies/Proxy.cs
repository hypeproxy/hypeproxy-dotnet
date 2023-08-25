using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Entities.Features;
using HypeProxy.Entities.Infrastructure;
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
    /// 
    /// </summary>
    public string? RemoteEntrypoint { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
	public string? RemoteHostname { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
	public int Port { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Port2 { get; set; }
}

public partial class Proxy
{
    // [JsonIgnore]
    // [ForeignKey(nameof(Purchase))]
    // public new Guid? PurchaseId { get; set; }
    //
    // [JsonIgnore]
    // public new virtual Purchase? Purchase { get; set; }

    [ForeignKey(nameof(ComputeUnit))]
    public Guid? ComputeUnitId { get; set; }
    
    [JsonIgnore]
    public virtual ComputeUnit? ComputeUnit { get; set; }

    [ForeignKey(nameof(Provider))]
    public Guid ProviderId { get; set; }
    
    [JsonIgnore]
    public virtual Provider Provider { get; set; }
    
    [ForeignKey(nameof(Credential))]
    public Guid CredentialId { get; set; }
    
    [JsonIgnore]
    public virtual Credential? Credential { get; set; }
    
    [JsonIgnore]
    public virtual IpRotation? IpRotation { get; set; }
}

public partial class Proxy
{
    [PublicApiIgnore]
    public string? Comment { get; set; }

    [PublicApiIgnore]
    public string? Interface { get; set; }

    [PublicApiIgnore]
    public string? MainData { get; set; }
}