using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Statuses;

[TranspilationSource]
[Table("RequestDetails")]
public partial class RequestDetail
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }

    public string? Endpoint { get; init; }
    public long Timestamp { get; init; }

    // [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UserAgent { get; set; }

    // [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ClientIp { get; set; }
}

public partial class RequestDetail
{
    [JsonIgnore]
    [ForeignKey(nameof(Status))]
    public Guid? StatusId { get; set; }
    
    [JsonIgnore]
    public virtual Status? Status { get; set; }
}
    
// [NotMapped]
// [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
// public Guid? UserId { get; set; }
// public DateTime CreatedAt { get; init; }