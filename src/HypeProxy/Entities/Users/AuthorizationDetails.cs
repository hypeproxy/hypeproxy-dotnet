using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Represents the authorizations of a user.
/// </summary>
[TranspilationSource]
public partial class AuthorizationDetails
{
    [Key]
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Guid Id { get; set; }
    
    public bool IsDenied { get; set; }
    
    public string? DeniedReason { get; set; }
    
    public DateTime? ExpiresOn { get; set; }
}

public partial class AuthorizationDetails
{
    [JsonIgnore]
    public virtual User User { get; set; }
}