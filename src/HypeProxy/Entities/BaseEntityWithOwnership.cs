using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public abstract class BaseEntityWithOwnership : BaseEntity
{
    [PublicApiIgnore]
    [JsonPropertyOrder(-2)]
    public DateTime? CreatedAt { get; set; }

    [PublicApiIgnore]
    [JsonPropertyOrder(-1)]
    public DateTime? UpdatedAt { get; set; }
    
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    
    [JsonIgnore]
    public virtual User User { get; set; }
}