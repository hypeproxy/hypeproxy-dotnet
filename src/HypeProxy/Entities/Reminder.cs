using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class Reminder : BaseEntityWithOwnership
{
    public string? ContactEmail { get; set; }

    public bool WasContacted { get; set; }
}

public partial class Reminder
{
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    
    [JsonIgnore]
    public virtual Product Product { get; set; }
    
    [ForeignKey(nameof(Location))]
    public Guid? LocationId { get; set; }
    
    [JsonIgnore]
    public virtual Location Location{ get; set; }
    
    [ForeignKey(nameof(Provider))]
    public Guid? ProviderId { get; set; }

    [JsonIgnore]
    public virtual Provider Provider { get; set; }
}