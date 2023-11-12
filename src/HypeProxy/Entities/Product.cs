﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Entities.Prices;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Defines a product (Mobile Proxies, Static Residential etc).
/// </summary>
[TranspilationSource]
public partial class Product : BaseEntity
{
    public string Name { get; set; }
    
    [PublicApiIgnore]
    public string? ShortName { get; set; }
    
    [PublicApiIgnore]
    public string? Tagline { get; set; }
    
    [PublicApiIgnore]
    public string? Label { get; set; }
    
    public string? ShortDescription { get; set; }
    
    public string? LongDescription { get; set; }
    
    [PublicApiIgnore]
    public string? WebDescription { get; set; }

    [PublicApiIgnore]
    public string? Icon { get; set; }

    [PublicApiIgnore]
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
    public int? BulkDiscountThreshold { get; set; }
    
    [PublicApiIgnore]
    public int? MinimumOrder { get; set; }
    
    // public IEnumerable<BillingCycles>? AvailableBillingCycles { get; set; }
}

public partial class Product
{
    [JsonIgnore]
    public virtual ICollection<Feature> Features { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Location> Locations { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Provider> Providers { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Price> Prices { get; set; }
}

public partial class Product
{
    [NotMapped]
    [PublicApiIgnore]
    public int AvailableStock { get; set; }

    [NotMapped]
    [PublicApiIgnore]
    public bool OutOfStock => AvailableStock == 0;
}