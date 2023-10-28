using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class UserSummaryResponse
{
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public string? Email { get; set; }
    public string Avatar { get; set; }
    
    public AuthorizationDetails? Authorization { get; set; }
}