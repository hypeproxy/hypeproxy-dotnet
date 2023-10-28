namespace HypeProxy.Payloads;

public class TelegramNotificationPayload : BasePayload
{
    public TelegramNotificationPayload()
    {
    }
    
    public TelegramNotificationPayload(BasePayload basePayload)
    {
        Title = basePayload.Title;
        Message = basePayload.Message;
        Level = basePayload.Level;
    }

    public string? Emoji { get; set; }
    public bool Pinned { get; set; }
    public bool HeadQuarter { get; set; }
    public Guid EntityId { get; set; }
    public Guid UserId { get; set; }
    public string UserDisplayHelper { get; set; }
    public string? ModelData { get; set; }
}