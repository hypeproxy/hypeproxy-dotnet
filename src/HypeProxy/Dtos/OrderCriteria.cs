using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class OrderCriteria
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

    public PaymentMethods PaymentMethod { get; set; } = PaymentMethods.CreditCard;
    public BillingPeriods BillingPeriod { get; set; } = BillingPeriods.Monthly;

    public int Quantity { get; set; } = 1;
    
    /// <summary>
    /// If you have a coupon you can indicate it.
    /// </summary>
    #nullable enable
    public string? CouponCode { get; set; }
    #nullable disable
    
    /// <summary>
    /// Renew the purchase at the end of billing period.
    /// </summary>
    public bool IsAutomaticallyRenewed { get; set; } = true;
}