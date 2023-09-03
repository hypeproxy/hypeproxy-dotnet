using HypeProxy.Constants;

namespace HypeProxy.Requests.Payloads;

public class EmailNotificationPayload
{
    public string? To { get; set; }
    public EmailTemplateNames TemplateName { get; set; }
    public object? DynamicData { get; set; }
}