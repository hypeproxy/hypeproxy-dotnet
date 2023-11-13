using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response related to a payment process.
/// </summary>
[TranspilationSource]
public class PaymentResponse
{
    /// <summary>
    /// Represents the return URL.
    /// </summary>
    public Uri ReturnUrl { get; set; }
    
    /// <summary>
    /// An object that can hold any custom data related to the payment.
    /// </summary>
    public object? CustomData { get; set; }
}