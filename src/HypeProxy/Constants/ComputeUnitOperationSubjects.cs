using System.Text.Json.Serialization;

namespace HypeProxy.Constants;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ComputeUnitOperationSubjects
{
    Ping,
    Initialize,
    RotateIp,
    IfDownIfUp,
    Enable,
    Disable,
    ChangeCredentials,
}