using System.Net.Http.Json;
using HypeProxy.Entities;
using HypeProxy.Requests;
using HypeProxy.Responses;

namespace HypeProxy.Infrastructure.Accessors;

#pragma warning disable CS0618
public class Purchases : BaseControllerAccessor<Purchase>
{
    public Purchases()
    {
        BaseAddress = "/v3/purchases";
    }

    public async Task<PaymentResponse?> CreateAsync(CreatePurchaseRequest createPurchaseRequest)
    {
        PreventNullClient();
        var xx = await Client.PostAsJsonAsync(BaseAddress, createPurchaseRequest);
        var apiResponseWithPaymentResponse = await xx.Content.ReadFromJsonAsync<ApiResponse<PaymentResponse>>();
        return apiResponseWithPaymentResponse?.Data;
    }

    public void DoSomething()
    {
    }
}