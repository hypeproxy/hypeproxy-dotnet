using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// These are the set of billing periods that we propose.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BillingPeriods
{
	Daily,
	Weekly,
	Monthly,
	Yearly
}
