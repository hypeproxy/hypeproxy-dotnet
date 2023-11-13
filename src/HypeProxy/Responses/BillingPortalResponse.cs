using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response that provides a URL to a billing portal.
/// </summary>
[TranspilationSource]
public class BillingPortalResponse
{
    /// <summary>
    /// Represents the URL of the billing portal.
    /// </summary>
    public Uri? ReturnUrl { get; set; }

    public BillingPortalResponse(string returnUrl)
    {
        ReturnUrl = new Uri(returnUrl);
    }
}