namespace HypeProxy.Attributes;

/// <summary>
/// Defines a property as censurable, e.g. protects this property in the logs.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class SensibleAttribute : Attribute
{
}