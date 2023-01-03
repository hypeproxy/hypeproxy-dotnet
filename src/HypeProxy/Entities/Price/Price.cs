using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities.Price;

[Orphan]
[TranspilationSource]
public class Price : BaseEntity
{
	private double _unitPrice;
	private int _quantity;

	[JsonIgnore]
	public Guid? ProductId { get; set; }
	
	public Guid? LocationId { get; set; }
	public Guid? ProviderId { get; set; }
	
	public PaymentMethods PaymentMethod { get; set; }
	public BillingPeriods BillingPeriod { get; set; }

	[PublicApiIgnore]
	public string PlanId { get; set; }
	
	[PublicApiIgnore]
	public string? PlanIdPeriod { get; set; }
	
	public double UnitPrice
	{
		get
		{
			var tiers = PriceTiers?.OrderBy(tiers => tiers.MaximumQuantity).ToList();
			var maxTiers = tiers?.Last();
			return _quantity >= maxTiers?.MaximumQuantity ? maxTiers.UnitPrice : tiers?.FirstOrDefault(tier => _quantity < tier.MaximumQuantity && _quantity > 1)?.UnitPrice ?? _unitPrice;
		}
		set => _unitPrice = value;
	}

	[JsonIgnore]
	public IEnumerable<PriceTiers>? PriceTiers { get; set; }

	public void DefineQuantity(int quantity) => _quantity = quantity;
}