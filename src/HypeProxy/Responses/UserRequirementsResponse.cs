using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class UserRequirementsResponse
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }
    
    public bool HadFirstLogin { get; set; }
    public bool RequireOnboarding { get; set; }
    public bool RequireKyc { get; set; }
    
    public bool HasConfirmedEmail { get; set; }
    public bool HasDefinedBillingDetails { get; set; }
    public bool HasDefinedUsageExplanation { get; set; }
    public bool HasAppliedKyc { get; set; }
}