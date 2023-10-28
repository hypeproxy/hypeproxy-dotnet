using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class BillingPortalResponse
{
    public Uri? ReturnUrl { get; set; }

    public BillingPortalResponse(string returnUrl)
    {
        ReturnUrl = new Uri(returnUrl);
    }
}