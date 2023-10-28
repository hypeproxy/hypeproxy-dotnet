using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using HypeProxy.Attributes;
using Tapper;
using YamlDotNet.Serialization;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ConfirmEmailRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [Sensible]
    [YamlIgnore]
    public string Token { get; set; }
}