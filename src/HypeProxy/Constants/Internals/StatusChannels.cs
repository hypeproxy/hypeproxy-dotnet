namespace HypeProxy.Constants.Internals;

[Flags]
public enum StatusChannels
{
    Email = 1,
    Notification = 2,
    Telegram = 4,
    Ntfy = 8,
    
    TelegramHq = Telegram | 8,
    TelegramPinned = Telegram | 16,
}
