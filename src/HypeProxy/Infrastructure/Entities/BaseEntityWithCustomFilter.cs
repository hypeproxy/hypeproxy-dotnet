using System.ComponentModel;
using Tapper;

namespace HypeProxy.Infrastructure.Entities;

/// <summary>
/// Represents an abstract base entity with a custom filter.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class BaseEntityWithCustomFilter : BaseEntity
{
}