using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Represents user-specific settings and preferences.
/// </summary>
[TranspilationSource]
public partial class UserSettings
{
	[Key]
    [JsonIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Guid Id { get; set; }
	
	/// <summary>
	/// Indicates whether the user has enabled developer mode.
	/// </summary>
	public bool DeveloperMode { get; set; }
	
	/// <summary>
	/// Indicates whether the user is enrolled in the beta program.
	/// </summary>
	public bool BetaEnrolled { get; set; }
	
	/// <summary>
	/// Indicates whether the user has chosen to skip the purchase assistant.
	/// </summary>
	public bool SkipPurchaseAssistant { get; set; }
	
	/// <summary>
	/// The default billing cycle selected by the user. Defaults to monthly.
	/// </summary>
    public BillingCycles DefaultBillingCycle { get; set; } = BillingCycles.Monthly;

	/// <summary>
	/// The default payment method selected by the user. Defaults to credit card.
	/// </summary>
    public PaymentMethods DefaultPaymentMethod { get; set; } = PaymentMethods.CreditCard;
}

public partial class UserSettings
{
	[JsonIgnore]
	public virtual User User { get; set; }
}