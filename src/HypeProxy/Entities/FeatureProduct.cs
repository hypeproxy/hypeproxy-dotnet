using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class FeatureProduct : BaseEntity, IJoint
{
	public Guid FeatureId { get; set; }
	public Guid ProductId  { get; set; }
}
