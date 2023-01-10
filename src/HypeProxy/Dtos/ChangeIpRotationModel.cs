using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HypeProxy.Dtos;

public class ChangeIpRotationModel
{
    [JsonIgnore]
    public Guid ProxyId { get; set; }
    
    [Required]
    public int Interval { get; set; }

    public ChangeIpRotationModel WithId(Guid proxyId)
    {
        ProxyId = proxyId;
        return this;
    }
}