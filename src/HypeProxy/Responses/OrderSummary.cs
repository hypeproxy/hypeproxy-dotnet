using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class OrderSummary
{
    public string Details { get; set; }
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

    [PublicApiIgnore]
    public int AvailableStockForCriteria { get; set; }
}