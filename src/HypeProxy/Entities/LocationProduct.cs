using HypeProxy.Attributes;
using HypeProxy.Interfaces;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class LocationProduct : BaseEntity, IJoint
{
	public Guid LocationId { get; set; }
	public Guid ProductId  { get; set; }
}
