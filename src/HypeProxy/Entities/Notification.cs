using System.ComponentModel;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Users;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Represents a notification for an <see cref="User"/>.
/// </summary>
[TranspilationSource]
public class Notification : BaseEntityWithOwnership
{
	/// <summary>
	/// The title of the notification.
	/// </summary>
	public string? Title { get; set; }
	
	/// <summary>
	/// The message content of the notification.
	/// </summary>
	public string? Message { get; set; }
	
	/// <summary>
	/// (Optional) The associated link with the notification. 
	/// </summary>
	public Uri? Link { get; set; }
	
	/// <summary>
	/// The warning level of the notification.
	/// </summary>
	public WarningLevels Level { get; set; }
    
	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Icons? Icon { get; set; }

	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool IsSeen { get; set; }
}