using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities;

// [Orphan]
[TranspilationSource]
public class Coupon : BaseEntity
{
	public string Name { get; set; }
	public string Description { get; set; }
	public bool IsOneTime { get; set; }
	public bool IsUsed { get; set; }
	public double PercentOff { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public DateTime? ExpirationDateTime { get; set; }
}