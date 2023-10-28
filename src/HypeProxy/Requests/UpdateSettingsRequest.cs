using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class UpdateSettingsRequest
{
    public bool? DeveloperMode { get; set; }
	
    public bool? BetaEnrolled { get; set; }
	
    public bool? SkipPurchaseAssistant { get; set; }
    
    public BillingCycles? DefaultBillingCycle { get; set; }
    
    public PaymentMethods? DefaultPaymentMethod { get; set; }
}