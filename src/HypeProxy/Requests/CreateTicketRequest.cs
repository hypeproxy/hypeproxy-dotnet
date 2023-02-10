using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class CreateTicketRequest
{
	[Required]
	public string Subject { get; set; }

	[Required]
	public string Message { get; set; }

	[RequiredEnum]
	public TicketPriorities Priority { get; set; }

	public Guid? RelatedPurchaseId { get; set; }
}
