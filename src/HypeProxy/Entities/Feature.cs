using System.ComponentModel;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Represnts a functionality for a given product.
/// </summary>
[TranspilationSource]
public partial class Feature : BaseEntity
{
    /// <summary>
    /// The name of the feature.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The tags associated with the feature.
    /// </summary>
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public FeatureTags Tag { get; set; }
    
    /// <summary>
    /// (Optional) A description providing additional information about the feature.
    /// </summary>
    public string? Description { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? Icon { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool VisibleSwitch { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? SwitchComponentName { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? BladeComponentName { get; set; }
}

public partial class Feature
{
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Product> Products { get; set; }
}