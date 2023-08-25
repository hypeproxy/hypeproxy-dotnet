using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// These are the set of billing cycles that we propose.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BillingCycles
{
	Monthly,
	Daily,
	Weekly,
	Yearly
}
