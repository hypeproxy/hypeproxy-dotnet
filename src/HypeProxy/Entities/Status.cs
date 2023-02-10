using HypeProxy.Constants;
using HypeProxy.Requests;

namespace HypeProxy.Entities;

public class Status : BaseEntity
{
	public string Title { get; set; }
	public string Message { get; set; }
	public WarningLevels Level { get; set; }
	public RequestDetails RequestDetails { get; set; }
}
