#nullable enable
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class SignInModel
{
	[Required]
	[EmailAddress(ErrorMessage = "The Email field is not a valid email address.")]
	public string Email { get; set; }

	[Sensible]
	[Required]
	[DataType(DataType.Password, ErrorMessage = "The Password field is not a valid password.")]
	public string Password { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? OtpCode { get; set; }
}
