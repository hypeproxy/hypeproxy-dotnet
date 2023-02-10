using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class ApiKeyResponse
{
    public Guid UserId { get; set; }
    
    [Sensible]
    public string Token { get; set; }
    
    public DateTime? TokenExpiration { get; set; }
}