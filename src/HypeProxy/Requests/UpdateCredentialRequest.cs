using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update user credentials.
/// </summary>
[TranspilationSource]
public class UpdateCredentialRequest
{
	/// <summary>
	/// The new username for the proxy.
	/// </summary>
	[Required]
	[RegularExpression("[0-9a-zA-Z.\\-_]*", ErrorMessage = "The username field can only contain alphanumeric characters.")]
	[StringLength(21, MinimumLength = 3, ErrorMessage = "The username should contain more than 3 characters and less than 21.")]
	public string Username { get; set; }

	/// <summary>
	/// The new password for the proxy.
	/// </summary>
	[Required]
	[DataType(DataType.Password)]
	[MinLength(6, ErrorMessage = "The password is too weak.")]
	public string Password { get; set; }
    
	/// <summary>
	/// (Optional) A collection of IP addresses that are authorized to access the proxy.
	/// </summary>
	public IEnumerable<string>? AuthorizedIps { get; set; }
}
