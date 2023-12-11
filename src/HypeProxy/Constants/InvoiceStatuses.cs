using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different statuses an invoice can have.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum InvoiceStatuses
{
	Created,
	Paid,
	Refunded,
	Canceled
}
