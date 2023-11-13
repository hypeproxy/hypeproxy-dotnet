using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to create a new support ticket.
/// </summary>
[TranspilationSource]
public class CreateTicketRequest
{
	/// <summary>
	/// The subject of the ticket.
	/// </summary>
	[Required]
	public string Subject { get; set; }

	/// <summary>
	/// The detailed message or description for the ticket.
	/// </summary>
	[Required]
	public string Message { get; set; }

	/// <summary>
	/// The priority level of the ticket.
	/// </summary>
	[RequiredEnum]
	public TicketPriorities Priority { get; set; }

	/// <summary>
	/// (Optional) The related purchase Id, if applicable.
	/// </summary>
	public Guid? RelatedPurchaseId { get; set; }
}
