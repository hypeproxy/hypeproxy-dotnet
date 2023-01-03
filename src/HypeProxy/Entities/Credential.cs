using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Microsoft.EntityFrameworkCore;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
[DependsOnPurchase]
[Index(nameof(Id), nameof(Username), IsUnique = true)]
public class Credential : BaseEntity
{
	public string Username { get; set; }
	public string Password { get; set; }
	
	public bool IsIpAuthenticationEnabled { get; set; }
	
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	#nullable enable
	public string? AuthorizedIp { get; set; }
	#nullable disable

	[PublicApiIgnore]
	public bool IsHttpEnabled { get; set; }

	[PublicApiIgnore]
	public bool IsSocksEnabled { get; set; }
}
