using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Invoices;
using HypeProxy.Entities.Prices;
using HypeProxy.Entities.Proxies;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Represents a purchase, linked with a list of <see cref="Proxy"/>.
/// </summary>
[TranspilationSource]
[Obsolete("Double check properties")]
public partial class Purchase : BaseEntityWithOwnership
{
    /// <summary>
    /// The date until which the purchase remains live.
    /// </summary>
    public DateTime? LiveUntil { get; set; }
    
    /// <summary>
    /// The status of the purchase.
    /// <see cref="PurchaseStatuses"/>
    /// </summary>
    public PurchaseStatuses Status { get; set; }
    
    /// <summary>
    /// Indicates whether the purchase is automatically renewed.
    /// </summary>
    public bool IsAutomaticallyRenewed { get; set; }
    
    /// <summary>
    /// The payment method used for the purchase.
    /// </summary>
    public PaymentMethods PaymentMethod { get; set; }    
    
    /// <summary>
    /// The billing cycle associated with the purchase.
    /// </summary>
    public BillingCycles BillingCycle { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? RelatedPaymentId { get; set; }
    
    /// <summary>
    /// Indicates whether the purchase is a trial.
    /// </summary>
    public bool IsTrial { get; set; }
}

public partial class Purchase
{
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    [JsonIgnore]
    public virtual Product Product { get; set; }
    
    [ForeignKey(nameof(Price))]
    public Guid PriceId { get; set; }
    
    public virtual Price Price { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Invoice> Invoices { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Proxy> Proxies { get; set; }
}

public partial class Purchase
{
    /// <summary>
    /// Indicates whether the purchase is in the grace period or not.
    /// </summary>
    [NotMapped]
    public bool IsGracePeriod =>
        Status == PurchaseStatuses.GracePeriod 
        || (Status == PurchaseStatuses.Live && LiveUntil < DateTime.UtcNow);

    /// <summary>
    /// Gets the end date of the grace period, if applicable.
    /// </summary>
    [NotMapped]
    public DateTime? GracePeriodEnd => IsGracePeriod ?
        BillingCycle switch
        {
            BillingCycles.Weekly => LiveUntil?.AddDays(1),
            BillingCycles.Daily => LiveUntil?.AddHours(3),
            BillingCycles.Yearly => LiveUntil?.AddDays(7),
            _ => LiveUntil?.AddDays(3)
        } : null;

    /// <summary>
    /// Indicates whether the purchase is refundable.
    /// </summary>
    [NotMapped]
    public bool IsRefundable =>
        DateTime.UtcNow <= CreatedAt?.AddHours(48) 
        && PaymentMethod == PaymentMethods.CreditCard;
}