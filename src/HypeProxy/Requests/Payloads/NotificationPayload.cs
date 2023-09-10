using HypeProxy.Constants;

namespace HypeProxy.Requests.Payloads;

public class NotificationPayload
{
    public Guid UserId { get; set; }
    public WarningLevels Level { get; set; }
    public string? Title { get; set; }
    public string? Message { get; set; }
    public Icons? Icon { get; set; }
    public string? Link { get; set; }
}