using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeSettingsRequest
{
    public bool? DeveloperMode { get; set; }
	
    public bool? BetaEnrolled { get; set; }
	
    public bool? SkipPurchaseAssistant { get; set; }
    
    // [Required]
    public BillingCycles? DefaultBillingCycle { get; set; }
    
    // [Required]
    public PaymentMethods? DefaultPaymentMethod { get; set; }
}