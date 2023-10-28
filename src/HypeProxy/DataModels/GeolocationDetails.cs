using Tapper;

namespace HypeProxy.DataModels;

[TranspilationSource]
public class GeolocationDetails
{
    public string Continent { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string CountryEmoji { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
}