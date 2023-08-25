using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Defines the compliance details of a <see cref="User"/>.
/// </summary>
[TranspilationSource]
public partial class ComplianceDetails
{
    [Key]
    [JsonIgnore]
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