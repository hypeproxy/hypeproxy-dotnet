using HypeProxy.Entities.Invoices;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Represents a coupon to use when making a purchase.
/// </summary>
[TranspilationSource]
public partial class Coupon : BaseEntityWithOwnership, IOptionalOwnership
{
	/// <summary>
	/// The coupon code.
	/// </summary>
	public string CouponCode { get; set; }
	
	/// <summary>
	/// A description providing additional information about the coupon.
	/// </summary>
    public string? Description { get; set; }
    
	/// <summary>
	/// The percentage discount offered by the coupon.
	/// </summary>
	public double PercentOff { get; set; }
    
	/// <summary>
	/// Indicates whether the coupon can be used only once.
	/// </summary>
	public bool IsSingleUse { get; set; }
	
	/// <summary>
	/// Indicates whether the coupon has been used.
	/// </summary>
	public bool IsRedeemed { get; set; }

	/// <summary>
	/// The expiration date and time of the coupon, if applicable.
	/// </summary>
	public DateTime? ExpiresOn { get; set; }
}

public partial class Coupon
{
	public virtual ICollection<Invoice> Invoices { get; set; }
}