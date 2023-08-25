using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Entities.Proxies;

[TranspilationSource]
public class AuthorizedIp
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }
    
    public string IpAddress { get; set; }
    
    [ForeignKey(nameof(Credential))]
    [JsonIgnore]
    public Guid CredentialId { get; set; }
    
    [JsonIgnore]
    public virtual Credential Credential { get; set; }
}