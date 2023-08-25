using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Joins;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Defines a functionality for a given product.
/// </summary>
[TranspilationSource]
public partial class Feature : BaseEntity
{
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    // [PublicApiIgnore]
    // public FeatureTypes Type { get; set; }
    
    [PublicApiIgnore]
    public string? Icon { get; set; }
}

public partial class Feature
{
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
}

public partial class Feature
{
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? FrontComponentName { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? BladeComponentName { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? ExtraComponentName { get; set; }
}