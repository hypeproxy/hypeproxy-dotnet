using System.ComponentModel.DataAnnotations;
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
/// Define a `Purchase`, containing a list of <see cref="Proxy"/>.
/// </summary>
[TranspilationSource]
[Obsolete("Double check properties")]
public partial class Purchase : BaseEntityWithOwnership
{
    /// <summary>
    /// Defines the `Purchase` expiration date.
    /// </summary>
    public DateTime? LiveUntil { get; set; }
    
    /// <summary>
    /// The status of the `Purchase`.
    /// </summary>
    public PurchaseStatuses Status { get; set; }
    
    /// <summary>
    /// If the purchase should be renewed at the end of the billing cycle.
    /// </summary>
    public bool IsAutomaticallyRenewed { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [EnumDataType(typeof(PaymentMethods))]
    public PaymentMethods PaymentMethod { get; set; }    
    
    /// <summary>
    /// Billing cycle: Daily, Weekly, Monthly, Yearly etc.
    /// </summary>
    [EnumDataType(typeof(BillingCycles))]
    public BillingCycles BillingCycle { get; set; }

    /// <summary>
    /// Defines the third party payment Id.
    /// </summary>
    [PublicApiIgnore]
    public string? RelatedPaymentId { get; set; }
    
    /// <summary>
    /// Defines whether the `Purchase` is a trial or not.
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
    
    /// <summary>
    /// Defines the proxies contained in this `Purchase`.
    /// </summary>
    [JsonIgnore]
    public virtual ICollection<Invoice> Invoices { get; set; }
    
    /// <summary>
    /// Defines the proxies contained in this `Purchase`.
    /// </summary>
    [JsonIgnore]
    public virtual ICollection<Proxy> Proxies { get; set; }
}

public partial class Purchase
{
    [NotMapped]
    public bool IsGracePeriod =>
        Status == PurchaseStatuses.GracePeriod 
        || (Status == PurchaseStatuses.Live && LiveUntil < DateTime.UtcNow);

    [NotMapped]
    public DateTime? GracePeriodEnd => IsGracePeriod ?
        BillingCycle switch
        {
            BillingCycles.Weekly => LiveUntil?.AddDays(1),
            BillingCycles.Daily => LiveUntil?.AddHours(3),
            BillingCycles.Yearly => LiveUntil?.AddDays(7),
            _ => LiveUntil?.AddDays(3)
        } : null;

    [NotMapped]
    public bool IsRefundable =>
        DateTime.UtcNow <= CreatedAt?.AddHours(48) 
        && PaymentMethod == PaymentMethods.CreditCard;
}