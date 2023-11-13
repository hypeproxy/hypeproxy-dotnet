using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tapper;

namespace HypeProxy.Entities.Prices;

[TranspilationSource]
[Table("PriceTiers")]
public partial class PriceTier
{
    [Key]
    public Guid Id { get; set; }
    
    public int VolumeThreshold { get; set; }
    
    public bool? IsInclusiveThreshold { get; set; }
    
    public double UnitPrice { get; set; }
}

public partial class PriceTier
{
    [ForeignKey(nameof(Price))]
    public Guid PriceId { get; set; }
    public virtual Price Price { get; set; }
}