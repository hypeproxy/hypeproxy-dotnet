using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class Notification : BaseEntity
{
	public string Title { get; set; }
	public string Message { get; set; }

	public WarningLevels Level { get; set; }

	public Icons Icon { get; set; }

	public bool IsSeen { get; set; }
}
