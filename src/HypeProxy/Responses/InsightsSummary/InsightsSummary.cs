using Tapper;

namespace HypeProxy.Responses.InsightsSummary;

[TranspilationSource]
public class InsightsSummary
{
    public string RemoteIp { get; set; }
    public LocationDetails GeolocationDetails { get; set; }
}