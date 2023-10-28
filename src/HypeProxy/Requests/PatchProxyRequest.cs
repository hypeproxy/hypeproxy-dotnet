using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class PatchProxyRequest
{
    [Required]
    [StringLength(50, ErrorMessage = "The `Comment` field is too long, it must not exceed 50 characters.")]
    public string Comment { get; set; }
}