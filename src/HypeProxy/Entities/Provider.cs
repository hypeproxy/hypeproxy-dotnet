using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class Provider : BaseEntity
{
	public string Name { get; set; }
	public string Description { get; set; }
	public string CompanyName { get; set; }
	public string WebsiteUrl { get; set; }
	public string LogoUrl { get; set; }

	[NotMapped]
	[JsonIgnore]
	public int AvailableStock { get; set; }

	[NotMapped]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool OutOfStock => AvailableStock == 0;
}
