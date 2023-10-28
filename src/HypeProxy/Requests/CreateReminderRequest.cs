using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class CreateReminderRequest
{
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [RequiredGuid]
    public Guid ProductId { get; set; }
    
    [Required]
    [RequiredGuid]
    public Guid LocationId { get; set; }
    
    [Required]
    [RequiredGuid]
    public Guid ProviderId { get; set; }
}