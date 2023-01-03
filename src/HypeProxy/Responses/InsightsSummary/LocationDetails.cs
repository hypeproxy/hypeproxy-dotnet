using Tapper;

namespace HypeProxy.Responses.InsightsSummary;

[TranspilationSource]
public class LocationDetails
{
    public string Continent { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string City { get; set; }
}