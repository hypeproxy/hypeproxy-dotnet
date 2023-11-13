using HypeProxy.Infrastructure.Requests;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to delete a purchase, with options for specifying a cancellation reason and claiming a refund.
/// </summary>
[TranspilationSource]
public class DeletePurchaseRequest : PurchaseRequest
{
    // TODO: Shouldn't be optional. 
    /// <summary>
    /// The reason why the purchase is being cancelled.
    /// </summary>
    [Obsolete]
    public string? CancellationReason { get; set; }
    
    /// <summary>
    /// If a refund is being claimed or not.
    /// </summary>
    public bool ClaimRefund { get; set; }
}