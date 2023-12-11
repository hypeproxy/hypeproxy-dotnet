using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Junctions;

[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
[Table("LocationProviders")]
public class LocationProvider
{
    [Key]
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Location))]
    public Guid LocationId { get; set; }
    public virtual Location Location { get; set; }
    
    [ForeignKey(nameof(Provider))]
    public Guid ProviderId { get; set; }
    public virtual Provider Provider { get; set; }
}