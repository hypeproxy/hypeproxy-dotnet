using HypeProxy.Constants;

namespace HypeProxy.Requests.Payloads;

public class TelegramNotificationPayload
{
    // public bool Fuck { get; set; }
    public string? Emoji { get; set; }
    public WarningLevels Level { get; set; }
    public string? Title { get; set; }
    public string? Message { get; set; }
    public object? ModelData { get; set; }
}