using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update the requirements or intended use of our service.
/// </summary>
[TranspilationSource]
public class UpdateRequirementsRequest
{
    /// <summary>
    /// The identifier of the usage domain, such as 'social-network-automation', 'data-scraping', etc.
    /// </summary>
    /// <remarks>
    /// The usage domain should be one of the following identifiers:
    /// - "social-network-automation"
    /// - "data-scraping"
    /// - "account-creation"
    /// - "game-bot"
    /// - "ad-verification"
    /// - "price-aggregation"
    /// - "seo-utility"
    /// - "traffic-generation"
    /// - "surveys"
    /// - "bypass-geo"
    /// - "other"
    /// </remarks>
    [Required]
    public string UsageDomain { get; set; }
    
    /// <summary>
    /// A description of the intended use or application of our service.
    /// </summary>
    [Required]
    public string UsageExplanation { get; set; }
}