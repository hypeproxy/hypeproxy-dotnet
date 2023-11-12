using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Infrastructure.Entities;

/// <summary>
/// This is the base entity, the whole of entities inherits from it.
/// </summary>
[TranspilationSource]
public abstract class BaseEntity
{
    [Key]
    [JsonPropertyOrder(-3)] 
    public Guid Id { get; set; }

    [PublicApiIgnore]
    public bool? IsFeatured { get; set; }

    [PublicApiIgnore] 
    public bool? IsAllowed { get; set; }

    [PublicApiIgnore]
    public int? Weight { get; set; }
}