using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Invoices;
using HypeProxy.Entities.Proxies;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Define a `Purchase`, containing a list of <see cref="Proxy"/>.
/// </summary>
[TranspilationSource]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(PaymentMethods))]
    public PaymentMethods PaymentMethod { get; set; }    
    
    /// <summary>
    /// Billing cycle: Daily, Weekly, Monthly, Yearly etc.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// <summary>
    /// 
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    [JsonIgnore]
    public virtual Product Product { get; set; }
    
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

// public partial class Purchase
// {
//     [NotMapped]
//     [PublicApiIgnore]
//     public bool IsAutomaticallyRenewable => 
//         PaymentMethod == PaymentMethods.CreditCard && 
//         Status == PurchaseStatuses.Live &&
//         RelatedPaymentId != null &&
//         RelatedPaymentId.StartsWith("sub_");
//
//     [NotMapped]
//     [PublicApiIgnore]
//     public bool IsRenewable =>
//         Status == PurchaseStatuses.Live &&
//         !IsAutomaticallyRenewed;
//
//     [NotMapped]
//     [PublicApiIgnore]
//     public bool IsRefundable =>
//         CreatedAt < DateTime.UtcNow.AddDays(2) &&
//         PaymentMethod == PaymentMethods.CreditCard;
//
//     [NotMapped]
//     public bool IsGracePeriod { get; set; }
//
//     [NotMapped]
//     [JsonIgnore]
//     public DateTime GracePeriodStartDateTime { get; set; }
// }