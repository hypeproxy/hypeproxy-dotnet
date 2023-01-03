using System.Net;

namespace HypeProxy.Exceptions;

[Serializable]
public class StatusCodeException : Exception
{
    public HttpStatusCode StatusCode { get; }

    public StatusCodeException(HttpStatusCode statusCode, string message) : base(message) => StatusCode = statusCode;
}