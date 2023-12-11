using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Entities;
using Tapper;

namespace HypeProxy.Infrastructure.Junctions;

[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
[Table("CredentialAuthorizedIps")]
public class CredentialAuthorizedIp
{
    [Key]
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Credential))]
    public Guid CredentialId { get; set; }
    public virtual Credential Credential { get; set; }
    
    public string AuthorizedIp { get; set; }
}