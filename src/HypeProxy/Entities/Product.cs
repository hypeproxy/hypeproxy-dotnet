using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Prices;
using HypeProxy.Infrastructure.Entities;
using HypeProxy.Infrastructure.Junctions;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Represents a product (Mobile Proxies, Static Residential etc).
/// </summary>
[TranspilationSource]
public partial class Product : BaseEntity
{
    /// <summary>
    /// The name of the product.
    /// </summary>
    public string Name { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? ShortName { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? Tagline { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? Label { get; set; }
    
    /// <summary>
    /// A short description of the product.
    /// </summary>
    public string? ShortDescription { get; set; }
    
    /// <summary>
    /// A long description of the product.
    /// </summary>
    public string? LongDescription { get; set; }
    
    [PublicApiIgnore]
    public string? WebDescription { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? Icon { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? IllustrationUrl { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Uri? PreHookUri { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Uri? PostHookUrl { get; set; }
}

public partial class Product
{
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int? BulkDiscountThreshold { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int? BulkDiscountValue { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int? MinimumOrder { get; set; }
}

public partial class Product
{
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<ProductLocation> ProductLocations { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<ProductFeature> ProductFeatures { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<ProductProvider> ProductProviders { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<ProductBillingCycle>? ProductBillingCycles { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Price> Prices { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Purchase> Purchases { get; set; }
}

public partial class Product
{
    [NotMapped]
    public int AvailableStock { get; set; }

    [NotMapped]
    public bool OutOfStock => AvailableStock == 0;

    [NotMapped]
    public IEnumerable<BillingCycles>? AvailableBillingCycles => ProductBillingCycles?.Any() == true
        ? ProductBillingCycles
            .Where(productBillingCycle => productBillingCycle.ProductId == Id)
            .Select(productBillingCycle => productBillingCycle.BillingCycle)
        : null; // Enum.GetValues<BillingCycles>();
}