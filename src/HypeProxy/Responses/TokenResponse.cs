using HypeProxy.Attributes;
using Tapper;
using YamlDotNet.Serialization;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response containing an API token.
/// </summary>
[TranspilationSource]
public class TokenResponse
{
    /// <summary>
    /// The unique identifier of the user associated with the token.
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// The JWT token value.
    /// </summary>
    [Sensible]
    [YamlIgnore]
    public string Token { get; set; }
    
    /// <summary>
    /// The expiration date and time of the token.
    /// </summary>
    public DateTime? TokenExpiration { get; set; }
}