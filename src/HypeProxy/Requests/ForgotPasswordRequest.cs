using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to initiate a password reset process for a user who has forgotten their password.
/// </summary>
[TranspilationSource]
public class ForgotPasswordRequest
{
	/// <summary>
	/// The email address of the user account.
	/// </summary>
	[Required]
	[EmailAddress(ErrorMessage = "The email field is not a valid email address.")]
	public string Email { get; set; }
}
