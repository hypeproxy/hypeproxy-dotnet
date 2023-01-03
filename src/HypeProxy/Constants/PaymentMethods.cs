using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PaymentMethods
{
	CreditCard,
	Cryptos
}
