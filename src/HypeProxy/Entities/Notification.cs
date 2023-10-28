using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
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
	public Uri? Link { get; set; }
    
    // [JsonConverter(typeof(JsonStringEnumConverter))]
    // [EnumDataType(typeof(WarningLevels))]
	public WarningLevels Level { get; set; }
    
	[PublicApiIgnore]
    // [JsonConverter(typeof(JsonStringEnumConverter))]
    // [EnumDataType(typeof(Icons))]
	public Icons? Icon { get; set; }

	public bool IsSeen { get; set; }
}

// public partial class Notification
// {
// 	[JsonIgnore]
// 	[ForeignKey(nameof(User))]
// 	[JsonPropertyName("TestUserId")]
// 	public new Guid? UserId { get; set; }
//     
// 	[JsonIgnore]
// 	public override User? User { get; set; }
// }