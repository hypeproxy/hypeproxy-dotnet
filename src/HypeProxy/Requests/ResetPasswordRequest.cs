using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;
using YamlDotNet.Serialization;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to reset a user's password.
/// </summary>
[TranspilationSource]
public class ResetPasswordRequest
{
	/// <summary>
	/// The email address of the user account.
	/// </summary>
	[EmailAddress]
	public string Email { get; set; }

	/// <summary>
	/// The token for password reset verification.
	/// </summary>
	[Required]
	[Sensible]
	[YamlIgnore]
	public string Token { get; set; }

	/// <summary>
	/// The new password for the account.
	/// </summary>
	[Required]
	[Sensible]
	[DataType(DataType.Password)]
	public string NewPassword { get; set; }
}
