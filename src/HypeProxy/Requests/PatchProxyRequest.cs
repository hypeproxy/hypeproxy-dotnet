using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update a proxy with specific details.
/// </summary>
[TranspilationSource]
public class PatchProxyRequest
{
    /// <summary>
    ///  A brief comment or note regarding the proxy.
    /// </summary>
    [Required]
    [StringLength(50, ErrorMessage = "The comment field is too long, it must not exceed 50 characters.")]
    public string Comment { get; set; }
}