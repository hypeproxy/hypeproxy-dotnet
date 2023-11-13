using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Invoices;

/// <summary>
/// Define an `Invoice` for a given <see cref="Purchase"/>.
/// </summary>
[TranspilationSource]
public partial class Invoice : BaseEntityWithOwnership
{
    // public string? Details { get; set; }
    
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
    /// The subtotal amount of the invoice.
    /// </summary>
	public decimal SubtotalAmount { get; set; }
	
    /// <summary>
    /// The total amount of the invoice.
    /// </summary>
	public decimal TotalAmount { get; set; }
	
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
    public virtual Purchase Purchase { get; set; }
    
    /// <summary>
    /// The items on the invoice.
    /// </summary>
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<InvoiceItem>? Items { get; set; }
}