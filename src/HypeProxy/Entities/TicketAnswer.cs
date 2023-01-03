using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class TicketAnswer : BaseEntity
{
	public Guid   TicketId { get; init; }
	public string Message  { get; set; }

	#nullable enable
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? AttachmentUrl { get; set; }
	#nullable disable
}
