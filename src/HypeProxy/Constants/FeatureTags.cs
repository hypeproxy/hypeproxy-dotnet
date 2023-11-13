using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different feature tags available.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FeatureTags
{
    IpRotation,
    IpAuthentication
}