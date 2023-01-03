using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Responses;

[TranspilationSource]
public class RequestDetails
{
    [JsonIgnore]
    public Guid Id { get; set; }
    
    [NotMapped]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid? UserId { get; set; }

    public string Endpoint { get; init; }
    public DateTime Date { get; init; }
    public long Timestamp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string UserAgent { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ClientIp { get; set; }
}