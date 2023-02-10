using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities.ApplicationUsers;

[TranspilationSource]
public class ConfidenceDetails
{
    [Key]
    [PublicApiIgnore]
    [JsonIgnore]
    public Guid Id { get; set; }
    
    // public bool IsKycRequested { get; set; }
    
    public bool HasAppliedKyc { get; set; }
    
    public string UsageDomain { get; set; }
    public string UsageExplanation { get; set; }
    
    public string KycId { get; set; }
}