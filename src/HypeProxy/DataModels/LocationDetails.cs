using Tapper;

namespace HypeProxy.DataModels;

[Obsolete]
[TranspilationSource]
public class LocationDetails
{
    public string Continent { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string CountryEmoji { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
}