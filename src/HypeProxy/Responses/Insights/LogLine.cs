using HypeProxy.Responses.InsightsSummary;

namespace HypeProxy.Responses.Insights;

public class LogLine
{
    public DateTime DateTime { get; set; }
    public string ServiceName { get; set; }
    public int ErrorCode { get; set; }
    public string ClientEndpoint { get; set; }
	public string TargetEndpoint { get; set; }
    public LocationDetails ClientLocation { get; set; }
    public LocationDetails TargetLocation { get; set; }
    public string HttpMethod { get; set; }
    public string Url { get; set; }
    public long ReceivedBytes { get; set; }
}
