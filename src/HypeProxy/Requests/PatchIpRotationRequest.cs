using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update the IP rotation of a proxy.
/// </summary>
[TranspilationSource]
public class PatchIpRotationRequest
{
    /// <summary>
    /// The interval in seconds after which the IP should be rotated.
    /// </summary>
    [Required]
    public int Interval { get; set; }
}