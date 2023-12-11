using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Infrastructure.Entities;

/// <summary>
/// Represents an abstract base entity.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class BaseEntity
{
    /// <summary>
    /// The unique identifier for the entity.
    /// </summary>
    [Key]
    [JsonPropertyOrder(-3)] 
    public Guid Id { get; set; }
    
    /// <summary>
    /// Indicates whether the entity is featured. 
    /// </summary>
    [PublicApiIgnore]
    public bool? IsFeatured { get; set; }

    /// <summary>
    /// Indicates whether the entity is allowed.
    /// </summary>
    [PublicApiIgnore] 
    public bool? IsAllowed { get; set; }

    /// <summary>
    /// (Optional) The weight of the entity (Can be used to sort entities.).
    /// </summary>
    [PublicApiIgnore]
    public int? Weight { get; set; }
}