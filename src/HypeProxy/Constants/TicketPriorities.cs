using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TicketPriorities
{
	Low = 1,
	Normal = 2,
	High = 3
}
