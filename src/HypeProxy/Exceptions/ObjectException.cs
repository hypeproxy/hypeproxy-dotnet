namespace HypeProxy.Exceptions;

[Obsolete]
public class ObjectException : Exception
{
    public dynamic ObjectData { get; set; }
	
    public ObjectException(dynamic objectData) => ObjectData = objectData;
}