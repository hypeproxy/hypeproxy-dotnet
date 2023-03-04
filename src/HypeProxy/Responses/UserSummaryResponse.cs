using System.Text.Json.Serialization;
using HypeProxy.Entities.ApplicationUsers;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class UserSummaryResponse
{
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public string Avatar { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AuthorizationDetails Authorization { get; set; }
}