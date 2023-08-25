using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class BaseEntityWithPurchaseContext : BaseEntity
{
    [ForeignKey(nameof(Purchase))]
    public Guid? PurchaseId { get; set; }
    
    [JsonIgnore]
    public virtual Purchase? Purchase { get; set; }
}