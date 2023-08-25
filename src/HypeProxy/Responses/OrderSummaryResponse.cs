using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class OrderSummaryResponse
{
    public string? Details { get; set; }
    public double UnitPrice { get; set; }
    
    [Obsolete("We remove the VAT inside LLC migration")]
    public double? VatAmount { get; set; }
    public double SubtotalAmount { get; set; }
    public double TotalAmount { get; set; }
    public string? CouponCode { get; set; }
    
    [Obsolete("Need to check which property is really needed")]
    public double? PriceOff { get; set; }
    
    [Obsolete("Need to check which property is really needed")]
    public double? PercentOff { get; set; }
}