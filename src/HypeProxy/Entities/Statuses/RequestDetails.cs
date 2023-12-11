using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Statuses;

[TranspilationSource]
[Table("RequestDetails")]
public partial class RequestDetails
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }

    public string? Endpoint { get; init; }
    public long Timestamp { get; init; }
    public string? UserAgent { get; set; }
    public string? ClientIp { get; set; }
}

public partial class RequestDetails
{
    [JsonIgnore]
    [ForeignKey(nameof(Status))]
    public Guid? StatusId { get; set; }
    
    [JsonIgnore]
    public virtual Status? Status { get; set; }
}