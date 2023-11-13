using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to create an answer for a ticket.
/// </summary>
[TranspilationSource]
public class CreateTicketAnswerRequest
{
	/// <summary>
	/// The message content for the ticket answer.
	/// </summary>
	[Required]
	public string Message { get; set; }
}
