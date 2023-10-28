using HypeProxy.Constants;
using HypeProxy.Constants.Internals;

namespace HypeProxy.Payloads;

public class StatusPayload : BasePayload
{
    public string? Emoji { get; set; }
    public Icons Icon { get; set; }
    public Guid UserId { get; set; }
    public string? ModelData { get; set; }
    public Guid EntityId { get; set; }
    public string UserDisplayHelper { get; set; }
    public IEnumerable<StatusChannels>? Channels { get; set; }
}
