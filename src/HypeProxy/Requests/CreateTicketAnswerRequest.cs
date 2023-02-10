using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class CreateTicketAnswerRequest
{
	[Required]
	public string Message { get; set; }
}
