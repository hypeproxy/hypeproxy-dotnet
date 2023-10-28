using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class CreatePurchaseRequest
{
    /// <summary>
    /// Product Id
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// Location Id
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid LocationId { get; set; }
    
    /// <summary>
    /// Provider Id
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid ProviderId { get; set; }

    public PaymentMethods PaymentMethod { get; set; }
    public BillingCycles BillingCycle { get; set; }

    public int Quantity { get; set; } = 1;
    
    /// <summary>
    /// If you have a coupon you can indicate it.
    /// </summary>
    public string? CouponCode { get; set; }
    
    /// <summary>
    /// Renew the purchase at the end of billing period.
    /// </summary>
    public bool IsAutomaticallyRenewed { get; set; }
}