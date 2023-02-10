using System.ComponentModel.DataAnnotations;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeUserSettingsRequest
{
    [Required]
    public BillingPeriods DefaultBillingPeriods { get; set; }
    
    [Required]
    public PaymentMethods DefaultPaymentMethods { get; set; }
}