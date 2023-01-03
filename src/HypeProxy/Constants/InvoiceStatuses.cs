using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

[TranspilationSource]
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
