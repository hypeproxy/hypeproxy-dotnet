using HypeProxy.Attributes;
using Tapper;
using YamlDotNet.Serialization;

namespace HypeProxy.Responses;

[TranspilationSource]
public class TokenResponse
{
    public Guid UserId { get; set; }
    
    [Sensible]
    [YamlIgnore]
    public string Token { get; set; }
    
    public DateTime? TokenExpiration { get; set; }
}