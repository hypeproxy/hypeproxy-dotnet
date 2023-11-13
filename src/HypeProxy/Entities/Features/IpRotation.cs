using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Proxies;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Features;

/// <summary>
/// Represents an IP rotation for a specific proxy.
/// <seealso cref="Proxy"/>
/// </summary>
[TranspilationSource]
public class IpRotation : BaseEntityWithCustomFilter
{
    [JsonIgnore]
    [ForeignKey(nameof(Proxy))]
    public Guid ProxyId { get; set; }
    
    /// <summary>
    /// The associated proxy.
    /// </summary>
    [JsonIgnore]
    public virtual Proxy Proxy { get; set; }
    
    /// <summary>
    /// The rotation period for IP rotation.
    /// </summary>
    [JsonIgnore]
    public TimeSpan TimeSpan { get; set; }

    /// <summary>
    /// The interval in seconds for IP rotation.
    /// </summary>
    [NotMapped]
    public double Interval => TimeSpan.TotalSeconds;
}