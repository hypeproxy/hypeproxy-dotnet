using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
[DependsOnPurchase]
[Orphan]
public class Renew : BaseEntity
{
    public Guid ProxyId { get; init; }

    public double EachMinutes { get; set; }
}