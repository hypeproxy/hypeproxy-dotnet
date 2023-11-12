using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Entities;

[TranspilationSource]
public abstract class BaseEntityWithPurchaseContext : BaseEntity
{
    [ForeignKey(nameof(Purchase))]
    public Guid? PurchaseId { get; set; }
    
    [JsonIgnore]
    public virtual Purchase? Purchase { get; set; }
}