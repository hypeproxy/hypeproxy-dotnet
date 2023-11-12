using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Proxies;
using HypeProxy.Infrastructure.Entities;
using Tapper;

// ReSharper disable once UnusedMember.Global
namespace HypeProxy.Entities;

/// <summary>
/// Defines an ISP provider.
/// </summary>
[TranspilationSource]
public partial class Provider : BaseEntity
{
	public string Name { get; set; }
	public string? Description { get; set; }
	public string? CompanyName { get; set; }
	public string? WebsiteUrl { get; set; }
	public string? LogoUrl { get; set; }

}

public partial class Provider
{
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Location> Locations { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Proxy> Proxies { get; set; }
}

public partial class Provider
{
    [NotMapped]
    public int AvailableStock { get; set; }

    [NotMapped]
    public bool OutOfStock => AvailableStock == 0;
}
