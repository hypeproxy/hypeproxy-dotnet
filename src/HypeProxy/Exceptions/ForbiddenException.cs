namespace HypeProxy.Exceptions;

[Serializable]
public class ForbiddenException : Exception
{
	public ForbiddenException(string? message = null) : base(message ?? "Attempt to access an forbidden resource.")
	{
	}
}