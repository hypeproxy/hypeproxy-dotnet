using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update a user's password.
/// </summary>
[TranspilationSource]
public class UpdatePasswordRequest
{
	/// <summary>
	/// The current password for the account.
	/// </summary>
	[Sensible]
	[Required]
	public string CurrentPassword { get; set; }

	/// <summary>
	/// The new password for the account.
	/// </summary>
	[Sensible]
	[Required]
	[MinLength(6, ErrorMessage = "The new password is too weak.")]
	[DataType(DataType.Password, ErrorMessage = "The is not a valid password.")]
	public string NewPassword { get; set; }

	/// <summary>
	/// The confirmation for the new password.
	/// </summary>
	[Sensible]
	[Required]
	[Compare("NewPassword", ErrorMessage = "The password confirmation does not match with the password.")]
	public string PasswordConfirmation { get; set; }
}
