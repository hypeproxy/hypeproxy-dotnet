using Microsoft.EntityFrameworkCore;
using Tapper;

namespace HypeProxy.Entities.Prices;

[Keyless]
[TranspilationSource]
public class PriceTiers
{
    public int MaximumQuantity { get; set; }
    public double UnitPrice { get; set; }

    public static string Serialize(IEnumerable<PriceTiers> priceTiers) => string.Join(";", priceTiers.Select(tiers => $"{tiers.MaximumQuantity}={tiers.UnitPrice}"));

    public static IEnumerable<PriceTiers> Deserialize(string priceTiersAsString) => priceTiersAsString
        .Split(";")
        .Select(tiers => tiers.Split("="))
        .Select(members => new PriceTiers 
        { 
            MaximumQuantity = Convert.ToInt32(members[0]), 
            UnitPrice = Convert.ToDouble(members[1])
        });
}
