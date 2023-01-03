using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class Location : BaseEntity
{
    public string Name { get; set; }

    public string City { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }

    [PublicApiIgnore]
    public string FlagUrl { get; set; }

    [NotMapped]
    [JsonIgnore]
    public int AvailableStock { get; set; }

    [NotMapped]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool OutOfStock => AvailableStock == 0;
}