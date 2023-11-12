using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Proxies;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Features;

/// <summary>
/// Defines the rotation of the IP address of a <see cref="Proxy"/>.
/// </summary>
[TranspilationSource]
public class IpRotation : BaseEntityWithCustomFilter
{
    /// <summary>
    /// Defines the relevant <see cref="Proxy"/>.
    /// </summary>
    [JsonIgnore]
    [ForeignKey(nameof(Proxy))]
    public Guid ProxyId { get; set; }
    
    [JsonIgnore]
    public virtual Proxy Proxy { get; set; }
    
    /// <summary>
    /// Rotation period.
    /// </summary>
    [JsonIgnore]
    public TimeSpan TimeSpan { get; set; }

    /// <summary>
    /// Interval in seconds.
    /// </summary>
    [NotMapped]
    public double Interval => TimeSpan.TotalSeconds;
}