using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class ApiKeyArtifact
{
    public Guid UserId { get; set; }
    
    [Sensible]
    public string Token { get; set; }
    
    public DateTime? TokenExpiration { get; set; }
}