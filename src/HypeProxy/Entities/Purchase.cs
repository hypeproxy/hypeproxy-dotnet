using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class Purchase : BaseEntity
{
	public Guid ProductId { get; init; }
	
	public DateTime StartDateTime { get; set; }
	public DateTime EndDateTime { get; set; }

	public IEnumerable<Guid> Content { get; init; }

	public PurchaseStatuses Status { get; set; }
	public PaymentMethods PaymentMethod { get; set; }
	public BillingPeriods BillingPeriod { get; init; }
	
	#nullable enable
	[PublicApiIgnore]
	public string? RelatedPaymentId { get; set; }
	#nullable disable

	[Obsolete]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Guid? CouponId { get; set; }

	public bool IsAutomaticallyRenewed { get; set; }
	
	public bool IsTrial { get; set; }
	
	[NotMapped]
	[PublicApiIgnore]
	public bool IsAutomaticallyRenewable => PaymentMethod == PaymentMethods.CreditCard && 
	                                        Status == PurchaseStatuses.Live &&
	                                        RelatedPaymentId != null &&
	                                        RelatedPaymentId.StartsWith("sub_");

	[NotMapped]
	[PublicApiIgnore]
	public bool IsRenewable => Status == PurchaseStatuses.Live && !IsAutomaticallyRenewed;

	[NotMapped]
	[PublicApiIgnore]
	public bool IsRefundable => DateTime.UtcNow.AddDays(2) <= StartDateTime;

	[NotMapped]
	public bool IsGracePeriod { get; set; }
	
	[NotMapped]
	[JsonIgnore]
	public DateTime GracePeriodStartDateTime { get; set; }
}