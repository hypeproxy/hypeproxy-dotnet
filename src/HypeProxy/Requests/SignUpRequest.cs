using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class SignUpRequest
{
	[Required]
	[EmailAddress(ErrorMessage = "The e-mail field is not a valid email address.")]
	[NoDisposableEmailAddress]
	public string Email { get; set; }

	[Required]
	[Sensible]
	[DataType(DataType.Password, ErrorMessage = "The password field is not a valid password.")]
	public string Password { get; set; }

	[Required]
	public string Fullname { get; set; }

	[PublicApiIgnore]
	[Sensible]
	[Required(ErrorMessage = "The fingerprint is required.")]
	[RegularExpression("[a-z0-9]{32}", ErrorMessage = "The `Fingerprint` field is not a valid fingerprint hash.")]
	public string Fingerprint { get; set; }

	[Required]
	[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept our terms in order to sign-up.")]
	public bool AcceptTerms { get; set; }
}
