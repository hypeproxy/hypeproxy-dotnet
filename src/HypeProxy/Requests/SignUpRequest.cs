using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to create a new user account.
/// </summary>
[TranspilationSource]
public class SignUpRequest
{
	/// <summary>
	/// The email address of the user.
	/// </summary>
	[Required]
	[EmailAddress(ErrorMessage = "The email field is not a valid email address.")]
	[NoDisposableEmailAddress]
	public string Email { get; set; }

	/// <summary>
	/// The password for the new account.
	/// </summary>
	[Required]
	[Sensible]
	[DataType(DataType.Password, ErrorMessage = "The password field is not a valid password.")]
	public string Password { get; set; }

	/// <summary>
	/// The full name of the user.
	/// </summary>
	[Required]
	public string Fullname { get; set; }

	/// <summary>
	/// The fingerprint hash (using fingerprint.js).
	/// </summary>
	[PublicApiIgnore]
	[Sensible]
	[Required(ErrorMessage = "The fingerprint is required.")]
	[RegularExpression("[a-z0-9]{32}", ErrorMessage = "The fingerprint field is not a valid fingerprint hash.")]
	public string Fingerprint { get; set; }

	/// <summary>
	/// Users must accept the terms and conditions to sign up.
	/// </summary>
	[Required]
	[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept our terms in order to sign-up.")]
	public bool AcceptTerms { get; set; }
}
