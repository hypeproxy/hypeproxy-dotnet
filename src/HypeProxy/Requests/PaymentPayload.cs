using HypeProxy.Entities;
using HypeProxy.Entities.Prices;

namespace HypeProxy.Requests;

public class PaymentPayload
{
    public OrderCriteriaRequest? OrderCriteriaRequest { get; set; }
    public Guid PurchaseId { get; set; }
    public string? PlanId { get; set; }

    public static PaymentPayload CreateInstance(OrderCriteriaRequest orderCriteriaRequest, Purchase purchase, Price price) => new()
    {
        OrderCriteriaRequest = orderCriteriaRequest, 
        PurchaseId = purchase.Id, 
        PlanId = price.PlanId
    };
}