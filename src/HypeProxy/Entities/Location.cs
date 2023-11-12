using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Infrastructure;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Defines an operating location for HyeProxy.io, usually a country or a city.
/// </summary>
[TranspilationSource]
public partial class Location : BaseEntity
{
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    [PublicApiIgnore]
    [ForeignKey(nameof(ParentLocation))]
    public Guid? ParentLocationId { get; set; }
    
    [JsonIgnore]
    public virtual Location? ParentLocation { get; set; }

    public CountryCodes? CountryCode { get; set; }

    [PublicApiIgnore]
    public string? FlagUrl { get; set; }
}

public partial class Location
{
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Provider> Providers { get; set; }
    
    [JsonIgnore]
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
