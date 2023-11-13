using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to create a new purchase.
/// </summary>
[TranspilationSource]
public class CreatePurchaseRequest
{
    /// <summary>
    /// the product Id.
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// the location Id.
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid LocationId { get; set; }
    
    /// <summary>
    /// the provider Id
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid ProviderId { get; set; }

    /// <summary>
    /// The payment method.
    /// </summary>
    public PaymentMethods PaymentMethod { get; set; }
    
    /// <summary>
    /// The billing cycle.
    /// </summary>
    public BillingCycles BillingCycle { get; set; }

    /// <summary>
    /// The quantity to order.
    /// </summary>
    public int Quantity { get; set; }
    
    /// <summary>
    /// (Optional) The coupon code for the purchase.
    /// </summary>
    public string? CouponCode { get; set; }
    
    /// <summary>
    /// If the purchase should be automatically renewed at the end of billing cycle.
    /// </summary>
    public bool IsAutomaticallyRenewed { get; set; }
}