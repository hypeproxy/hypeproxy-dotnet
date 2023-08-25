using System.ComponentModel.DataAnnotations;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeUserSettingsRequest
{
    [Required]
    public BillingCycles DefaultBillingCycle { get; set; }
    
    [Required]
    public PaymentMethods DefaultPaymentMethod { get; set; }
}