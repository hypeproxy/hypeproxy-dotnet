using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class DeletePurchaseRequest : PurchaseRequest
{
    public string? CancellationReason { get; set; }
    public bool ClaimRefund { get; set; }
}