using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class ConfirmEmailModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Token { get; set; }
}