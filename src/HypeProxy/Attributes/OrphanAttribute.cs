namespace HypeProxy.Attributes;

/// <summary>
/// To be used on entities that do not have an owner.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class OrphanAttribute : Attribute
{
}