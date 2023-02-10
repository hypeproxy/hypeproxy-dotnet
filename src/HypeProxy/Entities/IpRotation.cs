using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
[DependsOnPurchase]
[Orphan]
public class IpRotation : BaseEntity
{
    public Guid ProxyId { get; init; }

    /// <summary>
    /// Interval in minutes.
    /// </summary>
    public int Interval { get; set; }
    
    [JsonIgnore]
    public bool IsEnabled { get; set; }
}