using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Microsoft.EntityFrameworkCore;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
[DependsOnPurchase]
public class Credential : BaseEntity
{
	public string Username { get; set; }
	public string Password { get; set; }
	
	public bool IsIpAuthenticationEnabled { get; set; }
	
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<string>? AuthorizedIps { get; set; }
}
