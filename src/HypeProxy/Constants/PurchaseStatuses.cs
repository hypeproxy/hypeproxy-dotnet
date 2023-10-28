using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Describes the different status of a purchase.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PurchaseStatuses
{
	Created,
	Live,
	Off,
	
	[Display(Name = "Grace Period")]
    GracePeriod,
	
	// [Description("Describes the different status of a purchase.")]
	// Canceled,
	// Refunded
	// Provisioning
	// Removed
	// Extending
	Cancelled
}
