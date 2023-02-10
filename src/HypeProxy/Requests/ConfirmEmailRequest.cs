using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ConfirmEmailRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Token { get; set; }
}