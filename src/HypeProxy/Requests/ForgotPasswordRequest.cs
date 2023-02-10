using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ForgotPasswordRequest
{
	[Required]
	[EmailAddress(ErrorMessage = "It's not a valid email address.")]
	public string Email { get; set; }
}
