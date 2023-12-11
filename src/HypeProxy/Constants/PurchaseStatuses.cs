using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different statuses of a purchase.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PurchaseStatuses
{
	/// <summary>
	/// The purchase has been just created.
	/// </summary>
	Created,
	
	/// <summary>
	/// The purchase is active.
	/// </summary>
	Active,
	
	/// <summary>
	/// The purchase is not active anymore.
	/// </summary>
	Off,
	
	/// <summary>
	/// The purchase will be disabled shortly.
	/// </summary>
	[Display(Name = "Grace Period")]
    GracePeriod,
    
    /// <summary>
    /// The purchase is canceled.
    /// </summary>
    Canceled
}
