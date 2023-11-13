using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HypeProxy.Entities.Proxies;

// [TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public class AuthorizedIp
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }
    
    public string IpAddress { get; set; }
    
    [JsonIgnore]
    [ForeignKey(nameof(Credential))]
    public Guid CredentialId { get; set; }
    
    [JsonIgnore]
    public virtual Credential Credential { get; set; }
}