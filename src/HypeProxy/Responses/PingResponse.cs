using System.Net;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class PingResponse
{
    public bool IsOperational { get; set; }
    public int Reason { get; set; }
    public long ElapsedMilliseconds { get; set; }
}