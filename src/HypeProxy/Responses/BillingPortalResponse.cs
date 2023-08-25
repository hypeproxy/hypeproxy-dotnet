using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class BillingPortalResponse
{
    public string ReturnUrl { get; set; }
    
    public BillingPortalResponse()
    {
    }
    
    public BillingPortalResponse(string returnUrl)
    {
        ReturnUrl = returnUrl;
    }
}