using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Infrastructure;

/// <summary>
/// Defines a physical datacenter.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class Datacenter : BaseEntity
{
    /// <summary>
    /// The datacenter name (i.e. HDC1)
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// (Optional) The description of the datacenter.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The total capacity in number of bays in a datacenter.
    /// </summary>
    public int? Capacity { get; set; }

    /// <summary>
    /// Defines if a datacenter is operational or not.
    /// </summary>
    public bool IsOperational { get; set; }
    
    /// <summary>
    /// Indicates whether if a datacenter is temporary or not.
    /// </summary>
    public bool IsTemporary { get; set; }
}

public partial class Datacenter
{
    [ForeignKey(nameof(Location))]
    public Guid LocationId { get; set; }
    
    [JsonIgnore]
    public virtual Location Location { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Bay> Bays { get; set; }
}