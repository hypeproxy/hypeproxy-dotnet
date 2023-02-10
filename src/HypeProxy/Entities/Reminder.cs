using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class Reminder : BaseEntity
{
	public Guid ProductId { get; init; }
	public Guid? LocationId { get; set; }
	public Guid? ProviderId { get; set; }
	public string ContactEmail { get; init; }
	public bool WasContacted { get; set; }
}