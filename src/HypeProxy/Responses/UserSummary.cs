using System.Text.Json.Serialization;
using HypeProxy.Entities.ApplicationUser;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class UserSummary
{
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public string Avatar { get; set; }
    public long? MonthlyCosts { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AuthorizationDetails Authorization { get; set; }
}