using HypeProxy.Constants;
using HypeProxy.Constants.Internals;

namespace HypeProxy.Payloads;

public class ComputeUnitOperationPayload : BasePayloadForProxy
{
    public ComputeUnitOperationTypes Type { get; set; }
}