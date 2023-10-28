using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Define a coupon to use when making a purchase.
/// </summary>
[TranspilationSource]
public class Coupon : BaseEntityWithOwnership, IOptionalOwnership
{
	public Coupon()
	{
	}
	
	public Coupon(string code, double percentOff)
	{
		CouponCode = code;
		PercentOff = percentOff;
	}

	public string CouponCode { get; set; }
	
    public string? Description { get; set; }
    
	public double PercentOff { get; set; }
    
	public bool IsOneTime { get; set; }
	public bool IsUsed { get; set; }

	public DateTime? ExpireAt { get; set; }
}