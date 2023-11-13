using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Joins;

[TranspilationSource]
public abstract class ProductFeature
{
    [Key]
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
    
    [ForeignKey(nameof(Feature))]
    public Guid FeatureId { get; set; }
    public virtual Feature Feature { get; set; }
}