using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Defines the blocking and authorizations of a user.
/// </summary>
[TranspilationSource]
public class AuthorizationDetails
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }
    
    public bool IsDenied { get; set; }
    
    public string? DeniedReason { get; set; }
    
    public DateTime? BlockingDateTime { get; set; }
}