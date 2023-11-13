using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response containing the client's IP address.
/// </summary>
[TranspilationSource]
public class ClientIpResponse
{
    /// <summary>
    /// Represents the client's IP address.
    /// </summary>
    public string? ClientIp { get; set; }
}