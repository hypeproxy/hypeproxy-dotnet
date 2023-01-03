namespace HypeProxy.Exceptions;

[Serializable]
public class UnprocessablePaymentException : Exception
{
	public UnprocessablePaymentException(string? message = null) : base(message ?? "Unable to process your order.")
	{
	}
}