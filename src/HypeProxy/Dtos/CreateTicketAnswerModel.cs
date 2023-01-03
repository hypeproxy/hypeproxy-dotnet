using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class CreateTicketAnswerModel
{
	[Required]
	public string Message { get; set; }
}
