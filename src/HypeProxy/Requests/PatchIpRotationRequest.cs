using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class PatchIpRotationRequest
{
    /// <summary>
    /// Interval (in seconds).
    /// </summary>
    [Required]
    public int Interval { get; set; }
}