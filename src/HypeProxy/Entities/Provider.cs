using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Infrastructure.Entities;
using HypeProxy.Infrastructure.Junctions;
using Tapper;

// ReSharper disable once UnusedMember.Global
namespace HypeProxy.Entities;

/// <summary>
/// Defines an ISP provider.
/// </summary>
[TranspilationSource]
public partial class Provider : BaseEntity
{
	/// <summary>
	/// The name of the provider.
	/// </summary>
	public string Name { get; set; }
	
	/// <summary>
	/// A description providing additional information about the provider.
	/// </summary>
	public string? Description { get; set; }
    
	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string? CustomDisclaimerOrHint { get; set; }
	
	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string? CompanyName { get; set; }
	
	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string? WebsiteUrl { get; set; }
	
	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string? LogoUrl { get; set; }
}

public partial class Provider
{
	[JsonIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual ICollection<ProductProvider> ProductProviders { get; set; }
    
	[JsonIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual ICollection<LocationProvider> LocationProviders { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Proxy> Proxies { get; set; }
}

public partial class Provider
{
	[NotMapped]
    public int AvailableStock { get; set; }

    [NotMapped]
    public bool OutOfStock => AvailableStock == 0;
}
