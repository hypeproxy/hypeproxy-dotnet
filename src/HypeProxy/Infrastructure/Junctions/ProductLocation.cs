using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Junctions;

[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
[Table("ProductLocations")]
public class ProductLocation
{
    [Key]
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
    
    [ForeignKey(nameof(Location))]
    public Guid LocationId { get; set; }
    public virtual Location Location { get; set; }
}