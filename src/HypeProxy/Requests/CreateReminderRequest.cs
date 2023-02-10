using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class CreateReminderRequest
{
    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [RequiredGuid]
    public Guid ProductId { get; set; }
}