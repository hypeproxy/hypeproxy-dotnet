using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response containing user requirements.
/// </summary>
[TranspilationSource]
public class UserRequirementsResponse
{
    /// <summary>
    /// The unique identifier for the user requirements.
    /// </summary>
    
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }

    /// <summary>
    /// Indicates whether the user had their first login.
    /// </summary>
    public bool HadFirstLogin { get; set; }

    /// <summary>
    /// Indicates whether onboarding is required for the user.
    /// </summary>
    public bool RequireOnboarding { get; set; }

    /// <summary>
    /// Indicates whether Know Your Customer (KYC) is required for the user.
    /// </summary>
    public bool RequireKyc { get; set; }

    /// <summary>
    /// Indicates whether the user has confirmed their email.
    /// </summary>
    public bool HasConfirmedEmail { get; set; }

    /// <summary>
    /// Indicates whether the user has defined billing details.
    /// </summary>
    public bool HasDefinedBillingDetails { get; set; }

    /// <summary>
    /// Indicates whether the user has defined usage explanation.
    /// </summary>
    public bool HasDefinedUsageExplanation { get; set; }

    /// <summary>
    /// Indicates whether the user has applied for KYC.
    /// </summary>
    public bool HasAppliedKyc { get; set; }

    /// <summary>
    /// Indicates whether the user's KYC has been approved.
    /// </summary>
    public bool HasApprovedKyc { get; set; }
}
