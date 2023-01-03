using System.ComponentModel;

namespace HypeProxy.Constants;

public enum OwnershipRules
{
    Default,
    
    [Description("Don't filter entities based on their ownership.")]
    NoOwnershipFilter
}