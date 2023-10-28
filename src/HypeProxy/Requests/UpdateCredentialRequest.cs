using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class UpdateCredentialRequest
{
	[Required]
	[RegularExpression("[0-9a-zA-Z.\\-_]*", ErrorMessage = "The Username field can only contain alphanumeric characters.")]
	[StringLength(21, MinimumLength = 3, ErrorMessage = "This username should contain more than 3 characters and less than 21.")]
	public string Username { get; set; }

	[Required]
	[DataType(DataType.Password)]
	[MinLength(6, ErrorMessage = "This password is too weak.")]
	public string Password { get; set; }
    
	public IEnumerable<string>? AuthorizedIps { get; set; }
}
