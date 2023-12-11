using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Prices;

[TranspilationSource]
public partial class Price : BaseEntity
{
    /// <summary>
    /// The payment method associated with the price.
    /// </summary>
    public PaymentMethods PaymentMethod { get; set; }
    
    /// <summary>
    /// The billing cycle for the price.
    /// </summary>
    public BillingCycles BillingCycle { get; set; }
    
    /// <summary>
    /// The unit price for the product.
    /// </summary>
    public double UnitPrice { get; set; }
    
    [PublicApiIgnore]
    public string? SinglePaymentPlanId { get; set; }

    [PublicApiIgnore]
    public string? RecurringPaymentPlanId { get; set; }
}

public partial class Price
{
    /// <summary>
    /// The Id of the associated product. 
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// The Id of the associated location.
    /// </summary>
    [ForeignKey(nameof(Location))]
    public Guid? LocationId { get; set; }
    
    /// <summary>
    /// The Id of the associated provider.
    /// </summary>
    [ForeignKey(nameof(Provider))]
    public Guid? ProviderId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Product Product { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Location? Location { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Provider? Provider { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<PriceTier>? PriceTiers { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Purchase>? Purchases { get; set; }
}