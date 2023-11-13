using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Describes the different status of a purchase.
/// </summary>
[TranspilationSource]
[Obsolete("Needed review")]
// TODO: Needed review
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PurchaseStatuses
{
	Created,
	Live,
	Off,
	
	[Display(Name = "Grace Period")]
    GracePeriod,
    
    [Obsolete]
    // TODO: Cancelled or Canceled
	Cancelled
}
