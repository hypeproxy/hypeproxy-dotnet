using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Represents the compliance details of an user.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class ComplianceDetails
{
    [Key]
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Guid Id { get; set; }
    
    public bool HasRequestedKyc { get; set; }
    public bool? HasApprovedKyc { get; set; }
    public DateTime? ApprovedKycAt { get; set; }
    
    public string? KycId { get; set; }
}

public partial class ComplianceDetails
{
    public string? UsageDomain { get; set; }
    public string? UsageExplanation { get; set; }
}

public partial class ComplianceDetails
{
    [JsonIgnore]
    public virtual User User { get; set; }
}