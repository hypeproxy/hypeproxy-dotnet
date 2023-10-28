using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class PatchPurchaseRequest : PurchaseRequest
{
    public PaymentMethods? PaymentMethod { get; set; }
    public BillingCycles? BillingCycle { get; set; }
    
    public bool IsAutomaticallyRenewed { get; set; }
    
    public int CyclesQuantity { get; set; }
}