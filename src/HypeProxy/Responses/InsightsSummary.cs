using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class InsightsSummary
{
    public string RemoteIp { get; set; }
    public LocationDetails GeolocationDetails { get; set; }
}