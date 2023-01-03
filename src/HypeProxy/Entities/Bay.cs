using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class Bay : BaseEntity
{
	public string Name { get; set; }
	public Guid ProductId { get; set; }
	public Guid LocationId { get; set; }
}
