using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HypeProxy.Requests;

public class ChangeIpRotationRequest
{
    [JsonIgnore]
    public Guid ProxyId { get; set; }
    
    [Required]
    public int Interval { get; set; }
}