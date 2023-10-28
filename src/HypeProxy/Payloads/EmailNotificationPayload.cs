using HypeProxy.Constants;
using HypeProxy.Constants.Internals;

namespace HypeProxy.Payloads;

public class EmailNotificationPayload
{
    public string? To { get; set; }
    public EmailTemplateNames TemplateName { get; set; }
    public object? DynamicData { get; set; }
}