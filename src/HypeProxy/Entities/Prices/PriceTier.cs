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

    
// public int MaximumQuantity { get; set; }
// public double UnitPrice { get; set; }
//
// public static string Serialize(IEnumerable<PriceTier> priceTiers) => string.Join(";", priceTiers.Select(tiers => $"{tiers.MaximumQuantity}={tiers.UnitPrice}"));
//
// public static IEnumerable<PriceTier> Deserialize(string priceTiersAsString) => priceTiersAsString
//     .Split(";")
//     .Select(tiers => tiers.Split("="))
//     .Select(members => new PriceTier 
//     { 
//         MaximumQuantity = Convert.ToInt32(members[0]), 
//         UnitPrice = Convert.ToDouble(members[1])
//     });