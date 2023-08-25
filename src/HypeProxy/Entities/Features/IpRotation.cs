using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Proxies;
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
    /// Interval in seconds.
    /// </summary>
    public int Interval { get; set; }
    
    [JsonIgnore]
    public bool IsEnabled { get; set; }
}