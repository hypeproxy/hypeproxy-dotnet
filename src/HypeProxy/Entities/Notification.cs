using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Defines a `Notification` for an `User`.
/// </summary>
[TranspilationSource]
public class Notification : BaseEntityWithOwnership
{
	public string? Title { get; set; }
	public string? Message { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(WarningLevels))]
	public WarningLevels Level { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(Icons))]
	public Icons? Icon { get; set; }

	public bool IsSeen { get; set; }
}