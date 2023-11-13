using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a summary response for an order.
/// </summary>
[TranspilationSource]
public class OrderSummaryResponse
{
    /// <summary>
    /// Display order summary details.
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// The unit price of the product for the order.
    /// </summary>
    public double UnitPrice { get; set; }

    /// <summary>
    /// The VAT amount for the order.
    /// </summary>
    public double? VatAmount { get; set; }

    /// <summary>
    /// The subtotal amount for the order.
    /// </summary>
    public double SubtotalAmount { get; set; }

    /// <summary>
    /// The total amount of the order.
    /// </summary>
    public double TotalAmount { get; set; }

    /// <summary>
    /// The coupon code applied to the order, if available.
    /// </summary>
    public string? CouponCode { get; set; }

    /// <summary>
    /// The price reduction amount applied to the order, if available.
    /// </summary>
    public double? PriceOff { get; set; }

    /// <summary>
    /// The percentage discount applied to the order, if available.
    /// </summary>
    public double? PercentOff { get; set; }
}
