using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.ApplicationUsers;

[TranspilationSource]
public class AuthorizationDetails
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }
    
    public bool IsDenied { get; set; }
    
    public string DeniedReason { get; set; }
    
    public DateTime? BlockingDateTime { get; set; }
}