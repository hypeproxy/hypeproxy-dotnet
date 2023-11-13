using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to create a new reminder.
/// </summary>
[TranspilationSource]
public class CreateReminderRequest
{
    /// <summary>
    /// The email address where the reminder should be sent.
    /// </summary>
    [EmailAddress]
    public string? Email { get; set; }

    /// <summary>
    /// The product Id.
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// The location Id.
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid LocationId { get; set; }
    
    /// <summary>
    /// The provider Id.
    /// </summary>
    [Required]
    [RequiredGuid]
    public Guid ProviderId { get; set; }
}