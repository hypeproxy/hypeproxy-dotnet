using System.ComponentModel;

namespace HypeProxy.Attributes;

[EditorBrowsable(EditorBrowsableState.Never)]
[AttributeUsage(AttributeTargets.Property)]
public class PublicApiIgnoreAttribute : Attribute
{
}