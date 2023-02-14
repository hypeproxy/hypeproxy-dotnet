using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeCredentialsRequest
{
	[Required]
	[RegularExpression("[0-9a-zA-Z.\\-_]*", ErrorMessage = "The Username field can only contain alphanumeric characters.")]
	[StringLength(21, MinimumLength = 3, ErrorMessage = "This username should contain more than 3 characters and less than 21.")]
	public string Username { get; set; }

	[Required]
	[DataType(DataType.Password)]
	[MinLength(6, ErrorMessage = "This password is too weak.")]
	public string Password { get; set; }

	public bool IsIpAuthenticationEnabled { get; set; }

	[RequiredIfTrue(nameof(IsIpAuthenticationEnabled), ErrorMessage = "The `AuthorizedIps` field is required.")]
	public IEnumerable<string> AuthorizedIps { get; set; }
}
