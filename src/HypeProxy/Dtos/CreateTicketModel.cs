using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class CreateTicketModel
{
	[Required]
	public string Subject { get; set; }

	[Required]
	public string Message { get; set; }

	[RequiredEnum]
	public TicketPriorities Priority { get; set; }

	public Guid? RelatedPurchaseId { get; set; }
}
