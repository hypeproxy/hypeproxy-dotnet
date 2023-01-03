using System.ComponentModel.DataAnnotations;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class ChangeUserSettingsModel
{
    [Required]
    public BillingPeriods DefaultBillingPeriods { get; set; }
    
    [Required]
    public PaymentMethods DefaultPaymentMethods { get; set; }
}