namespace HypeProxy.Payloads;

public abstract class ChangeCredentialsPayload : BasePayloadForProxy
{
    public string Username { get; set; }
    public string Password { get; set; }
    public IEnumerable<string>? AuthorizedIps { get; set; }
}