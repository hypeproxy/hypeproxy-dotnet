using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update various user settings.
/// </summary>
[TranspilationSource]
public class UpdateSettingsRequest
{
	/// <summary>
	/// If developer mode is enabled or not.
	/// </summary>
    public bool? DeveloperMode { get; set; }
	
	/// <summary>
	/// If the user is enrolled in beta features or not.
	/// </summary>
    public bool? BetaEnrolled { get; set; }
	
	/// <summary>
	/// If the purchase assistant is to be skipped or not.
	/// </summary>
    public bool? SkipPurchaseAssistant { get; set; }
    
	/// <summary>
	/// The default billing cycle.
	/// </summary>
    public BillingCycles? DefaultBillingCycle { get; set; }
    
	/// <summary>
	/// The default payment method.
	/// </summary>
    public PaymentMethods? DefaultPaymentMethod { get; set; }
}