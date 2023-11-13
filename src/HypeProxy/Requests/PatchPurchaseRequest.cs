using HypeProxy.Constants;
using HypeProxy.Infrastructure.Requests;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update the details of an existing purchase.
/// </summary>
[TranspilationSource]
public class PatchPurchaseRequest : PurchaseRequest
{
    /// <summary>
    /// (Optional) The new payment method, if changing.
    /// </summary>
    public PaymentMethods? PaymentMethod { get; set; }
    
    /// <summary>
    /// (Optional) The new billing cycle, if changing.
    /// </summary>
    public BillingCycles? BillingCycle { get; set; }
    
    /// <summary>
    /// If the purchase should be automatically renewed.
    /// </summary>
    public bool IsAutomaticallyRenewed { get; set; }
    
    /// <summary>
    /// The quantity of billing cycles for the purchase.
    /// </summary>
    public int CyclesQuantity { get; set; }
}