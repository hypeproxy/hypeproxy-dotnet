using System.ComponentModel.DataAnnotations;

namespace HypeProxy.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class RequiredIfTrueAttribute : RequiredAttribute
{
    public RequiredIfTrueAttribute(string propertyName) => PropertyName = propertyName;

    private string PropertyName { get; }

    protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
    {
        var instance = validationContext.ObjectInstance;
        var type = instance.GetType();

        var _ = bool.TryParse(type.GetProperty(PropertyName)
            ?.GetValue(instance)
            ?.ToString(), out var propertyValue);

        return propertyValue && string.IsNullOrWhiteSpace(value?.ToString())
            ? new ValidationResult(ErrorMessage)
            : ValidationResult.Success;
    }
}