using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[DependsOnPurchase]
[TranspilationSource]
public class ProductDetail : BaseEntity
{
	public Guid ProductId { get; set; }
	public Guid LocationId { get; set; }
	public Guid BayId { get; set; }
	public Guid ProviderId { get; set; }

	public Guid CredentialsId { get; set; }
	public string RemoteEndpoint { get; set; }
	public string RemoteHostname { get; set; }
	public int Port { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Port2 { get; set; }

	[PublicApiIgnore]
	public bool IsAvailable { get; set; }

	[PublicApiIgnore]
	public string Comment { get; set; }

	[PublicApiIgnore]
	public string Interface { get; set; }

	[PublicApiIgnore]
	public string MainData { get; set; }
}