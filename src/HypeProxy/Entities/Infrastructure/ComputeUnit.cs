using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Proxies;
using Tapper;

namespace HypeProxy.Entities.Infrastructure;

/// <summary>
/// Defines a server within an <see cref="Bay"/>, which runs proxies.
/// </summary>
[TranspilationSource]
public partial class ComputeUnit : BaseEntity
{
    /// <summary>
    /// `ComputeUnit` name (i.e. HCU001)
    /// </summary>
    public string Name { get; set; }
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
    
    [JsonIgnore]
    public virtual ICollection<Proxy> Proxies { get; set; }
}