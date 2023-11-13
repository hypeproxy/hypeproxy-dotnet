using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response from a ping operation, indicating operational status.
/// </summary>
[TranspilationSource]
public class PingResponse
{
    /// <summary>
    /// If the service is operational or not.
    /// </summary>
    public bool IsOperational { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public int Reason { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public long ElapsedMilliseconds { get; set; }
}