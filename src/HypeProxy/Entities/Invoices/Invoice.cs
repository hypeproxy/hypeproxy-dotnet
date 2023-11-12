using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
    /// Defines the status of the `Invoice`.
    /// </summary>
    public InvoiceStatuses Status { get; set; }
    
    public PaymentMethods PaymentMethod { get; set; }
	
	public decimal SubtotalAmount { get; set; }
	
	public decimal TotalAmount { get; set; }
	
	public string? ThirdPartyInvoiceId { get; set; }
	public string? HostedInvoiceUrl { get; set; }
	public string? HostedInvoicePdfUrl { get; set; }
}

public partial class Invoice
{
    /// <summary>
    /// Defines the relevant <see cref="Purchase"/>.
    /// </summary>
    [ForeignKey(nameof(Purchase))]
    public Guid PurchaseId { get; set; }
    
    [JsonIgnore]
    public virtual Purchase Purchase { get; set; }
    
    /// <summary>
    /// Items on the `Invoice`.
    /// </summary>
    // [JsonIgnore]
    public virtual ICollection<InvoiceItem>? Items { get; set; }
}