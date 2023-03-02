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
	Off
	
	// [Description("Describes the different status of a purchase.")]
	// Canceled,
	// Refunded
	// Provisioning
	// Removed
	// Extending
}
