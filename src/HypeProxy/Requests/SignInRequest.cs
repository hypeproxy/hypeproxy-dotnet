using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to sign in to an account and return API token response.
/// </summary>
[TranspilationSource]
public class SignInRequest
{
	/// <summary>
	/// The email address of the user.
	/// </summary>
	[Required]
	[EmailAddress(ErrorMessage = "The email field is not a valid email address.")]
	public string Email { get; set; }

	/// <summary>
	/// The password for the account
	/// </summary>
	[Sensible]
	[Required]
	[DataType(DataType.Password, ErrorMessage = "The password field is not a valid password.")]
	public string Password { get; set; }

	/// <summary>
	/// (Optional) The OTP code for two-factor authentication.
	/// </summary>
	[PublicApiIgnore]
	[Sensible]
	public string? OtpCode { get; set; }
}
