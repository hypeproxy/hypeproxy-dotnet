using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class ChangeRequirementsModel
{
    [Required]
    public string UsageDomain { get; set; }
    
    [Required]
    public string UsageExplanation { get; set; }
}