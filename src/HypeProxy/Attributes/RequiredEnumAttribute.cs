using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HypeProxy.Attributes;

[EditorBrowsable(EditorBrowsableState.Never)]
public class RequiredEnumAttribute : RequiredAttribute
{
	public override bool IsValid(object? value)
	{
		if (value == null) return false;
		var type = value.GetType();

		return type.IsEnum && Enum.IsDefined(type, value);
	}
}
