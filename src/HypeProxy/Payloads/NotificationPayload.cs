using HypeProxy.Constants;

namespace HypeProxy.Payloads;

public class NotificationPayload : BasePayload
{
    public NotificationPayload()
    {
    }
    
    public NotificationPayload(BasePayload basePayload)
    {
        Title = basePayload.Title;
        Message = basePayload.Message;
        Level = basePayload.Level;
    }

    public Icons? Icon { get; set; }
    public string? Link { get; set; }
    public Guid UserId { get; set; }
}