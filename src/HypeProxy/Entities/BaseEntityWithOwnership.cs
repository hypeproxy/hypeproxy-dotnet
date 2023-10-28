using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public abstract class BaseEntityWithOwnership : BaseEntity
{
    [JsonPropertyOrder(-2)]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyOrder(-1)]
    public DateTime? UpdatedAt { get; set; }
    
    [JsonIgnore]
    [ForeignKey(nameof(User))]
    public Guid? UserId { get; set; }
    
    [JsonIgnore]
    public virtual User? User { get; set; }
}