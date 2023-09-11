using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Defines the settings of a <see cref="User"/>.
/// </summary>
[TranspilationSource]
public class UserSettings
{
	[Key]
    [JsonIgnore]
	public Guid Id { get; set; }
	
	public bool DeveloperMode { get; set; }
	
	public bool BetaEnrolled { get; set; }
	
	// public IEnumerable<AuthorizedIp>? DefaultAuthorizedIps { get; set; }

    public BillingCycles DefaultBillingPeriods { get; set; } = BillingCycles.Monthly;

    public PaymentMethods DefaultPaymentMethods { get; set; } = PaymentMethods.CreditCard;
}
