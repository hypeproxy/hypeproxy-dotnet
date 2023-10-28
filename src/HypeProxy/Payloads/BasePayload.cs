using HypeProxy.Constants;

namespace HypeProxy.Payloads;

public class BasePayload
{
    public WarningLevels Level { get; set; }
    public string? Title { get; set; }
    public string? Message { get; set; }
    // public Icons? Icon { get; set; }
    // public string? Emoji { get; set; }
}