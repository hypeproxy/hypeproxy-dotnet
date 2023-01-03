using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class ForgotPasswordModel
{
	[Required]
	[EmailAddress(ErrorMessage = "It's not a valid email address.")]
	public string Email { get; set; }
}
