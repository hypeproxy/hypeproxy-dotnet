using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different statuses an invoice can have.
/// </summary>
[TranspilationSource]
[Obsolete("Needed review")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum InvoiceStatuses
{
	Draft,
	Issued,
	Paid,
	NotPaid,
	Refunded,
	Canceled
}
