using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
[DependsOnPurchase]
[Orphan]
public class Renew : BaseEntity
{
    public Guid ProductDetailsId { get; init; }

    // [JsonConverter(typeof(TimespanConverter))]
    // public TimeSpan EachTimeSpan { get; set; }

    [NotMapped]
    public double EachMinutes { get; set; }
}