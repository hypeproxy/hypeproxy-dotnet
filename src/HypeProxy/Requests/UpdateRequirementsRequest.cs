using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class UpdateRequirementsRequest
{
    [Required]
    public string UsageDomain { get; set; }
    
    [Required]
    public string UsageExplanation { get; set; }
}