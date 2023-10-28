using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
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
    
    [PublicApiIgnore]
    public string? Icon { get; set; }
    
    [PublicApiIgnore]
    public bool VisibleSwitch { get; set; }
    
    [PublicApiIgnore]
    public string? SwitchComponentName { get; set; }
    
    [PublicApiIgnore]
    public string? BladeComponentName { get; set; }
    
    [PublicApiIgnore]
    public FeatureTags Tag { get; set; }
}

public partial class Feature
{
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
}