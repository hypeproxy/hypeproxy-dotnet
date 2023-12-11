using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Entities;

/// <summary>
/// Represents an abstract base entity with purchase context.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class BaseEntityWithPurchaseContext : BaseEntity
{
    /// <summary>
    /// The unique identifier of the purchase associated with the entity.
    /// </summary>
    [ForeignKey(nameof(Purchase))]
    public Guid? PurchaseId { get; set; }
    
    /// <summary>
    /// The purchase associated with the entity.
    /// </summary>
    [JsonIgnore]
    public virtual Purchase? Purchase { get; set; }
}