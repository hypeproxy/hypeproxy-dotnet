namespace HypeProxy.Requests.Payloads;

public abstract class ChangeCredentialsPayload : BasePayload
{
    public string Username { get; set; }
    public string Password { get; set; }
    public IEnumerable<string>? AuthorizedIps { get; set; }
}