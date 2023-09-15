using System.Text.Json.Serialization;
using HypeProxy.Attributes;
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
    
    public bool VisibleSwitch { get; set; }
    
    public string? SwitchComponentName { get; set; }
    public string? BladeComponentName { get; set; }
}

public partial class Feature
{
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
}