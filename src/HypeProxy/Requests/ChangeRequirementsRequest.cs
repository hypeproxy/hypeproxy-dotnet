using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeRequirementsRequest
{
    [Required]
    public string UsageDomain { get; set; }
    
    [Required]
    public string UsageExplanation { get; set; }
}