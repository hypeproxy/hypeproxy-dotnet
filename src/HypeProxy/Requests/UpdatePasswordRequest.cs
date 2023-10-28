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
	[MinLength(6, ErrorMessage = "This password is too weak.")]
	[DataType(DataType.Password, ErrorMessage = "This is not a valid password.")]
	public string NewPassword { get; set; }

	[Sensible]
	[Required]
	[Compare("NewPassword", ErrorMessage = "The PasswordConfirmation field doesn't match with NewPassword field.")]
	public string PasswordConfirmation { get; set; }
}
