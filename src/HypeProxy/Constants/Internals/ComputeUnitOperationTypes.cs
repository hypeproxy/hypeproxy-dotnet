using System.Text.Json.Serialization;

namespace HypeProxy.Constants.Internals;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ComputeUnitOperationTypes
{
    Ping,
    Initialize,
    RotateIp,
    IfDownIfUp,
    Enable,
    Disable,
    ChangeCredentials,
}