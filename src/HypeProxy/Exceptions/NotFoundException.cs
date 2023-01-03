namespace HypeProxy.Exceptions;

[Serializable]
public class NotFoundException : Exception
{
	public NotFoundException(string? message = null) : base(message)
	{
	}

	public NotFoundException() : base("Unable to find this resource.")
	{
	}
}