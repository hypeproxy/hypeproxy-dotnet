using Tapper;

namespace HypeProxy.Responses.Insights.Summary;

[TranspilationSource]
public class InsightsSummary
{
    public string RemoteIp { get; set; }
    public string InternetServiceProvider { get; set; }
    public string Asn { get; set; }
    public int TrustScore { get; set; }
    public LocationDetails GeolocationDetails { get; set; }
}