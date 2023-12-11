using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Infrastructure;

/// <summary>
/// Defines a server within an <see cref="Bay"/>, which runs proxies.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class ComputeUnit : BaseEntity
{
    /// <summary>
    /// The compute unit name (i.e. HCU001)
    /// </summary>
    public string Name { get; set; }
    
    public string SubscriptionAddress { get; set; }
    
    /// <summary>
    /// (Optional) The description of the compute unit.
    /// </summary>
    public string? Description { get; set; }
}

public partial class ComputeUnit
{
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    [JsonIgnore]
    public virtual Product Product { get; set; }

    [ForeignKey(nameof(Bay))]
    public Guid? BayId { get; set; }
    
    [JsonIgnore]
    public virtual Bay? Bay { get; set; }
    
    [ForeignKey(nameof(Location))]
    public Guid? OrphanLocationId { get; set; }
    
    [JsonIgnore]
    public virtual Location? OrphanLocation { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Proxy> Proxies { get; set; }
}