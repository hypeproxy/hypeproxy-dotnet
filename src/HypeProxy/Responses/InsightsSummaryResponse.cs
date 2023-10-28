using HypeProxy.DataModels;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
[Obsolete]
public class InsightsSummaryResponse
{
    public string? RemoteIp { get; set; }
    public string? InternetServiceProvider { get; set; }
    public string? Asn { get; set; }
    public int TrustScore { get; set; }
    public GeolocationDetails GeolocationDetails { get; set; }
}