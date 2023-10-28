using System.Text.Json.Serialization;

namespace HypeProxy.Constants.Internals;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PaymentPurposes
{
    PurchaseCreate,
    PurchaseUpdate,
    AddonCreate
}