using System.ComponentModel.DataAnnotations;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities.ApplicationUser;

[TranspilationSource]
public class UserSettings
{
	[Key]
	public Guid Id { get; set; }
	
	public BillingPeriods? DefaultBillingPeriods { get; set; }
	
	public PaymentMethods? DefaultPaymentMethods { get; set; }
}
