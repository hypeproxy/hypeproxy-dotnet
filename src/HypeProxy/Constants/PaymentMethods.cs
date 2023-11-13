using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different payment methods available.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PaymentMethods
{
	/// <summary>
	/// Represents payment via credit card.
	/// </summary>
	[Display(Name = "Credit Card")]
	CreditCard,
    
	/// <summary>
	/// Represents payment via cryptocurrency.
	/// </summary>
	[Display(Name = "Cryptocurrency")]
	Cryptocurrency,
    
	/// <summary>
	/// Represents payment via Alipay.
	/// </summary>
	[Display(Name = "Alipay")]
	Alipay,
    
	/// <summary>
	/// Represents payment via WebMoney.
	/// </summary>
	[Display(Name = "WebMoney")]
	WebMoney,
    
	/// <summary>
	/// Represents payment via PayPal.
	/// </summary>
	[Display(Name = "PayPal")]
	PayPal
}
