using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class SignUpRequest
{
	[Required]
	[EmailAddress(ErrorMessage = "The `Email` field is not a valid email address.")]
	[NoDisposableEmailAddress]
	public string Email { get; set; }

	[Required]
	[Sensible]
	[DataType(DataType.Password, ErrorMessage = "The `Password` field is not a valid password.")]
	public string Password { get; set; }

	[Required]
	public string Fullname { get; set; }

	[PublicApiIgnore]
	[Sensible]
	[Required]
	[RegularExpression("[a-z0-9]{32}", ErrorMessage = "The `Fingerprint` field is not a valid fingerprint hash.")]
	public string Fingerprint { get; set; }

	[Required]
	[Range(typeof(bool), "true", "true", ErrorMessage = "The `AcceptTerms` field is required and should be true.")]
	public bool AcceptTerms { get; set; }
}
