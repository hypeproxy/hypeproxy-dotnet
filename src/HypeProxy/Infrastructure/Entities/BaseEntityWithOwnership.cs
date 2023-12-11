using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Infrastructure.Entities;

/// <summary>
/// Represents an abstract base entity with ownership information.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class BaseEntityWithOwnership : BaseEntity
{
    /// <summary>
    /// The date and time when the entity was created. 
    /// </summary>
    [JsonPropertyOrder(-2)]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The date and time when the entity was last updated.
    /// </summary>
    [JsonPropertyOrder(-1)]
    public DateTime? UpdatedAt { get; set; }
    
    /// <summary>
    /// (Optional) The unique identifier of the user associated with the entity.
    /// </summary>
    [JsonIgnore]
    [ForeignKey(nameof(User))]
    public Guid? UserId { get; set; }
    
    /// <summary>
    /// The user associated with the entity.
    /// </summary>
    [JsonIgnore]
    public virtual User? User { get; set; }
}