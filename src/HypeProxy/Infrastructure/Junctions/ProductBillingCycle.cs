using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Constants;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Junctions;

[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
[Table("ProductBillingCycles")]
public class ProductBillingCycle
{
    [Key]
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    public virtual Product Product { get; set; }
    
    public BillingCycles BillingCycle { get; set; }
}