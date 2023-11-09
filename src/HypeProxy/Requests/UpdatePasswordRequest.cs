using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class UpdatePasswordRequest
{
	[Sensible]
	[Required]
	public string CurrentPassword { get; set; }

	[Sensible]
	[Required]
	[MinLength(6, ErrorMessage = "The new password is too weak.")]
	[DataType(DataType.Password, ErrorMessage = "This is not a valid password.")]
	public string NewPassword { get; set; }

	[Sensible]
	[Required]
	[Compare("NewPassword", ErrorMessage = "The password confirmation does not match with the password.")]
	public string PasswordConfirmation { get; set; }
}
