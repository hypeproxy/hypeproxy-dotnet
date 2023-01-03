using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Entities.ApplicationUser;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class Invoice : BaseEntity
{
	[Obsolete]
	public Guid ProductId { get; set; }
	
	public Guid PurchaseId { get; set; }
	public InvoiceStatuses Status { get; set; }
	
	public PaymentMethods PaymentMethod { get; set; }
	
	public BillingDetails BillingDetails { get; set; }

	public int ItemQuantity { get; set; }
	
	public double UnitPrice { get; set; }
    
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public double? VatAmount { get; set; }
	
	public double SubtotalAmount { get; set; }
	
	public double TotalAmount { get; set; }
	
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	#nullable enable
	public string? CouponCode { get; set; }
	#nullable disable
    
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public double? PriceOff { get; set; }
    
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public double? PercentOff { get; set; }
	
	public string ThirdPartyInvoiceId { get; set; }

	public string HostedInvoiceUrl { get; set; }
	public string HostedInvoicePdfUrl { get; set; }
	
	[NotMapped]
	public string ItemName { get; set; }
	
	[NotMapped]
	public string Details { get; set; }

	// public static Invoice FromPrice(Price price) => new()
	// {
	// 	UnitPrice = price.UnitPrice,
	// 	VatAmount = price.VatAmount,
	// 	SubtotalAmount = price.SubtotalAmount,
	// 	TotalAmount = price.TotalAmount,
	// 	CouponCode = price.CouponCode,
	// 	PriceOff = price.PriceOff,
	// 	PercentOff = price.PercentOff,
	// };
}
