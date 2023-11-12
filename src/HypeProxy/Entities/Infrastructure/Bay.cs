using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Infrastructure;

/// <summary>
/// Defines a rack server within a HypeProxy.io <see cref="Datacenter"/>.
/// </summary>
[TranspilationSource]
public partial class Bay : BaseEntity
{
    /// <summary>
    /// `Bay` name (e.g. FRA1)
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Number of stages in a `Bay`.
    /// </summary>
    public int? Stages { get; set; }
    
    /// <summary>
    /// Standard size of a `Bay` (U format).
    /// </summary>
    public int? Size { get; set; } = 32;
    
    /// <summary>
    /// Defines if a `Bay` is operational or not.
    /// </summary>
    public bool IsOperational { get; set; }
}

public partial class Bay
{
    [ForeignKey(nameof(Datacenter))]
    public Guid DatacenterId { get; set; }
    
    [JsonIgnore]
    public virtual Datacenter Datacenter { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<ComputeUnit> ComputeUnits { get; set; }
}