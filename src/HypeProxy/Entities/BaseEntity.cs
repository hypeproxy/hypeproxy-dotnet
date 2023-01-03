using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public abstract class BaseEntity
{
	[Key]
	[JsonPropertyOrder(-5)]
	[Column(Order = 0)]
	public Guid Id { get; set; }

	[JsonPropertyOrder(-3)]
	[PublicApiIgnore]
	[Column(Order = 1)] 
	public Guid? Owner { get; set; }

	[PublicApiIgnore]
	[JsonPropertyOrder(-2)]
	[Column(Order = 2)]
	public DateTime? CreationDateTime { get; set; }

	[PublicApiIgnore]
	[JsonPropertyOrder(-1)]
	[Column(Order = 3)]
	public DateTime? LastUpdateDateTime { get; set; }

	[PublicApiIgnore]
	public bool? IsFeatured { get; set; }

	[PublicApiIgnore]
	public bool? IsAllowed { get; set; }

	[PublicApiIgnore]
	public int? Weight { get; set; }

	[PublicApiIgnore]
	public string? ContextData { get; set; }

	[PublicApiIgnore]
	public string? CustomData { get; set; }

	[PublicApiIgnore]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool IsNew => CreationDateTime != null && CreationDateTime.Value.AddMonths(1) > DateTime.UtcNow;
}
