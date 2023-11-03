using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class UserSummaryResponse
{
    public Guid UserId { get; set; }
    public string? UserHash { get; set; }
    public string FullName { get; set; }
    public string? Email { get; set; }
    public string Avatar { get; set; }
    
    public DateTime RegisteredAt { get; set; }
    public AuthorizationDetails? Authorization { get; set; }
    public BillingDetails? BillingDetails { get; set; }
}