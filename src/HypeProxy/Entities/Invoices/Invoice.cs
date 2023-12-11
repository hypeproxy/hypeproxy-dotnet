using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Users;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Invoices;

/// <summary>
/// Define an `Invoice` for a given <see cref="Purchase"/>.
/// </summary>
[TranspilationSource]
public partial class Invoice : BaseEntityWithOwnership
{
	[JsonIgnore]
	[ForeignKey(nameof(BillingDetails))]
	public Guid BillingDetailsId { get; set; }
	public virtual BillingDetails BillingDetails { get; set; }
	
    /// <summary>
    /// The current status of the invoice.
    /// <see cref="InvoiceStatuses"/>
    /// </summary>
    public InvoiceStatuses Status { get; set; }
    
    /// <summary>
    /// The payment method used for the invoice.
    /// </summary>
    public PaymentMethods PaymentMethod { get; set; }
	
    /// <summary>
    /// The taxes amount of the invoice, if applicable.
    /// </summary>
    public decimal? TaxesAmount { get; set; }
    
    /// <summary>
    /// The discount amount of the invoice, if applicable.
    /// </summary>
    public decimal? DiscountAmount { get; set; }
    
    /// <summary>
    /// The subtotal amount of the invoice.
    /// </summary>
	public decimal SubtotalAmount { get; set; }
	
    /// <summary>
    /// The total amount of the invoice.
    /// </summary>
	public decimal TotalAmount { get; set; }
	
    [ForeignKey(nameof(Coupon))]
    public Guid? CouponId { get; set; }
    
    [JsonIgnore]
    public virtual Coupon? Coupon { get; set; }
    
    /// <summary>
    /// The third-party invoice ID associated with the invoice. 
    /// </summary>
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
	public string? ThirdPartyInvoiceId { get; set; }
    
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
	public string? HostedInvoiceUrl { get; set; }
	
	/// <summary>
	/// (Optional) The hosted PDF URL for the invoice, if applicable.
	/// </summary>
	public string? HostedInvoicePdfUrl { get; set; }
}

public partial class Invoice
{
    /// <summary>
    /// The Id of the relevant purchase.
    /// </summary>
    [ForeignKey(nameof(Purchase))]
    public Guid PurchaseId { get; set; }
    
    /// <summary>
    /// The associated purchase.
    /// </summary>
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Purchase Purchase { get; set; }
    
    /// <summary>
    /// The items on the invoice.
    /// </summary>
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ICollection<InvoiceItem>? Items { get; set; }
}