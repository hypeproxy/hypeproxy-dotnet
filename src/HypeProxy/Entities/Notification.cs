using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
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
	public WarningLevels Level { get; set; }
    
	[PublicApiIgnore]
	public Icons? Icon { get; set; }

	public bool IsSeen { get; set; }
}