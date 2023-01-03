using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class Ticket : BaseEntity
{
	public string Subject { get; set; }
	public TicketPriorities Priority { get; set; }

	[PublicApiIgnore]
	public string Category { get; set; }

	public string Message { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Guid? RelatedPurchaseId { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? AttachmentUrl { get; set; }
	
	public bool IsClosed { get; set; }
}
