using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ResetPasswordRequest
{
	[EmailAddress]
	public string Email { get; set; }

	[Required]
	public string Token { get; set; }

	[Required]
	[DataType(DataType.Password)]
	public string NewPassword { get; set; }

	[Required]
	[DataType(DataType.Password)]
	[Compare("NewPassword", ErrorMessage = "The PasswordConfirmation field doesn't match with NewPassword field.")]
	public string PasswordConfirmation { get; set; }
}
