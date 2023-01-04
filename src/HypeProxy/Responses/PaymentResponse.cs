using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class PaymentResponse
{
    public Uri ReturnUrl { get; set; }
    public object CustomData { get; set; }
}