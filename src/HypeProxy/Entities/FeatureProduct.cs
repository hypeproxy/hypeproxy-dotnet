using HypeProxy.Attributes;
using HypeProxy.Interfaces;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class FeatureProduct : BaseEntity, IJoint
{
	public Guid FeatureId { get; set; }
	public Guid ProductId  { get; set; }
}
