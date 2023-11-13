using HypeProxy.DataModels;
using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a summary response for insights of a proxy.
/// </summary>
[TranspilationSource]
public class InsightsSummaryResponse
{
    /// <summary>
    /// The remote IP address through the proxy.
    /// </summary>
    public string? RemoteIp { get; set; }
    
    /// <summary>
    /// The ISP's name if available.
    /// </summary>
    public string? InternetServiceProvider { get; set; }
    
    /// <summary>
    /// The ASN number if available.
    /// </summary>
    public string? Asn { get; set; }
    
    /// <summary>
    /// The trust score of the proxy's IP.
    /// </summary>
    public int TrustScore { get; set; }
    
    /// <summary>
    /// The geolocation details associated with the proxy.
    /// </summary>
    public GeolocationDetails GeolocationDetails { get; set; }
}