using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;
using YamlDotNet.Serialization;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to confirm an email address.
/// </summary>
[TranspilationSource]
public class ConfirmEmailRequest
{
    /// <summary>
    /// The email address that needs confirmation.
    /// </summary>
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    /// <summary>
    /// The token that is used to confirm the email address.
    /// </summary>
    [Required]
    [Sensible]
    [YamlIgnore]
    public string Token { get; set; }
}