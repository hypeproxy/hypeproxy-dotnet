using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Joins;

[TranspilationSource]
public class ProductProvider
{
    [Key]
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
    
    [ForeignKey(nameof(Provider))]
    public Guid ProviderId { get; set; }
    public virtual Provider Provider { get; set; }
}