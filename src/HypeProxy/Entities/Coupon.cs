using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Define a coupon to use when making a purchase.
/// </summary>
[TranspilationSource]
[Obsolete]
public class Coupon : BaseEntityWithOwnership
{
    public string Code { get; set; }
    
    public string? Description { get; set; }
    
	public double PercentOff { get; set; }
    
	public bool IsOneTime { get; set; }
	public bool IsUsed { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public DateTime? ExpireAt { get; set; }
}