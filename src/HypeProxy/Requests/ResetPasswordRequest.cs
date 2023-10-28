using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;
using YamlDotNet.Serialization;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ResetPasswordRequest
{
	[EmailAddress]
	public string Email { get; set; }

	[Required]
	[Sensible]
	[YamlIgnore]
	public string Token { get; set; }

	[Required]
	[Sensible]
	[DataType(DataType.Password)]
	[Compare("NewPassword", ErrorMessage = "The PasswordConfirmation field doesn't match with NewPassword field.")]
	public string NewPassword { get; set; }
}
