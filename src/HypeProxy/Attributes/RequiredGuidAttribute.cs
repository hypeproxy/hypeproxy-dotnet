using System.ComponentModel.DataAnnotations;

namespace HypeProxy.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class RequiredGuidAttribute : RequiredAttribute
{
	public override bool IsValid(object value)
	{
		if (value is null) return true;

		return value switch
		{
			Guid guid => guid != Guid.Empty,
			_ => true
		};
	}
}
