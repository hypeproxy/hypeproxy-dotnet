using HypeProxy.Attributes;
using HypeProxy.Interfaces;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class ProviderLocation : BaseEntity, IJoint
{
    public Guid ProviderId { get; set; }
    public Guid LocationId  { get; set; }
}