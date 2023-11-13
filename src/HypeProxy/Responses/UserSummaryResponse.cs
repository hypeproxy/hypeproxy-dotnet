using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a summary response for a user.
/// </summary>
[TranspilationSource]
public class UserSummaryResponse
{
    /// <summary>
    /// The user's unique identifier.
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// The hash value of the user, if available.
    /// </summary>
    public string? UserHash { get; set; }
    
    /// <summary>
    /// The user's full name.
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// The user's email address, if available.
    /// </summary>
    public string? Email { get; set; }
    
    /// <summary>
    /// The URL of the user's avatar.
    /// </summary>
    public string Avatar { get; set; }
    
    /// <summary>
    /// The date and time when the user registered.
    /// </summary>
    public DateTime RegisteredAt { get; set; }
    
    /// <summary>
    /// The user's authorization details, if available.
    /// </summary>
    public AuthorizationDetails? Authorization { get; set; }
    
    /// <summary>
    /// The user's billing details, if available.
    /// </summary>
    public BillingDetails? BillingDetails { get; set; }
}