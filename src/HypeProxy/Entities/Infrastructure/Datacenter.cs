using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Infrastructure;

/// <summary>
/// Defines a physical `Datacenter`.
/// </summary>
[TranspilationSource]
public partial class Datacenter : BaseEntity
{
    /// <summary>
    /// `Datacenter` name (i.e. HDC1)
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Optional description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The total capacity in number of bays in a `Datacenter`.
    /// </summary>
    public int? Capacity { get; set; }

    /// <summary>
    /// Defines if a `Datacenter` is operational or not.
    /// </summary>
    public bool IsOperational { get; set; }
    
    /// <summary>
    /// Defines if a `Datacenter` is temporary or not.
    /// </summary>
    public bool IsTemporary { get; set; }
}

public partial class Datacenter
{
    /// <summary>
    /// Location of the `Datacenter`.
    /// </summary>
    [ForeignKey(nameof(Location))]
    public Guid LocationId { get; set; }
    
    [JsonIgnore]
    public virtual Location Location { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Bay> Bays { get; set; }
}