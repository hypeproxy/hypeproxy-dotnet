using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Infrastructure;
using HypeProxy.Infrastructure.Entities;
using HypeProxy.Infrastructure.Junctions;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Represents an operating location for HyeProxy.io, usually a country or a city.
/// </summary>
[TranspilationSource]
public partial class Location : BaseEntity
{
    /// <summary>
    /// The name of the location.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// (Optional) A description providing additional information about the location.
    /// </summary>
    public string? Description { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? CustomDisclaimerOrHint { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ForeignKey(nameof(ParentLocation))]
    public Guid? ParentLocationId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Location? ParentLocation { get; set; }

    /// <summary>
    /// The country code associated with the location (i.e. Fr, Es etc).
    /// </summary>
    public CountryCodes? CountryCode { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? FlagUrl { get; set; }
}

public partial class Location
{
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<ProductLocation> ProductLocations { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<LocationProvider> LocationProviders { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Datacenter>? Datacenters { get; set; }
}

/// <summary>
/// Property helpers.
/// </summary>
public partial class Location
{
    [NotMapped]
    public int AvailableStock { get; set; }

    [NotMapped]
    public bool OutOfStock => AvailableStock == 0;
}
