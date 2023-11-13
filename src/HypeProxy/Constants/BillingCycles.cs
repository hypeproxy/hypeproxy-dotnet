using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different billing cycle options.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BillingCycles
{
    /// <summary>
    /// Represents a billing cycle that occurs monthly.
    /// </summary>
    Monthly,

    /// <summary>
    /// Represents a billing cycle that occurs daily.
    /// </summary>
    Daily,

    /// <summary>
    /// Represents a billing cycle that occurs weekly.
    /// </summary>
    Weekly,

    /// <summary>
    /// Represents a billing cycle that occurs yearly.
    /// </summary>
    Yearly
}
