using System.ComponentModel;
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
	// [Description("Describes the different status of a purchase.")]
	Created,
	
	// Provisioning,
	
	Live,
	Canceled,
	Refunded,
	Off,
	Removed,
	// Extending
}
