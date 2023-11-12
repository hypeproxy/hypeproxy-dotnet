using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Prices;

[TranspilationSource]
public partial class Price : BaseEntity
{
    public PaymentMethods PaymentMethod { get; set; }
    public BillingCycles BillingCycle { get; set; }
    
    // public bool IsAutomaticRenewEnabled { get; set; }
    
    public double UnitPrice { get; set; }
    
    // [PublicApiIgnore]
    // public string? PlanId { get; set; }
    
    [PublicApiIgnore]
    public string? OneTimePaymentPlanId { get; set; }

    [PublicApiIgnore]
    public string? RecurringPaymentPlanId { get; set; }
}

public partial class Price
{
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    [ForeignKey(nameof(Location))]
    public Guid? LocationId { get; set; }
    
    [ForeignKey(nameof(Provider))]
    public Guid? ProviderId { get; set; }
    
    public virtual Product Product { get; set; }
    public virtual Location? Location { get; set; }
    public virtual Provider? Provider { get; set; }
    
    public virtual ICollection<PriceTier>? PriceTiers { get; set; }
    
    public virtual ICollection<Purchase>? Purchases { get; set; }
}