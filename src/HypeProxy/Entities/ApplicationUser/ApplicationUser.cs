using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Microsoft.AspNetCore.Identity;
using Tapper;

namespace HypeProxy.Entities.ApplicationUser;

[TranspilationSource]
public class ApplicationUser : IdentityUser<Guid>
{
	[JsonPropertyOrder(-2)]
	public override Guid Id { get; set; }

	// public Guid Uid => Guid.Parse(Id);

	// [Key]
	// [JsonPropertyOrder(-2)]
	// [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	// public override Guid Id
	// {
	// 	get => base.Id;
	// 	set => base.Id = value;
	// }

	[JsonPropertyOrder(-2)]
	public override string Email { get; set; }

	public string FullName { get; set; }
	
	public BillingDetails BillingDetails { get; set; }
	
	[PublicApiIgnore]
	[JsonIgnore]
	public ConfidenceDetails ConfidenceDetails { get; set; }

	[PublicApiIgnore]
	public string StripeCustomerId { get; set; }

	public DateTime RegistrationDateTime { get; set; }

	public string CultureConcern { get; set; }

	[PublicApiIgnore]
	public int SecurityFlag { get; set; }

	[PublicApiIgnore]
	public string PasswordSignature { get; set; }

	[PublicApiIgnore]
	public string FingerprintId { get; set; }
	
	[PublicApiIgnore]
	public AuthorizationDetails AuthorizationDetails { get; set; }

	public UserSettings Settings { get; set; }
	
	public bool HadFirstLogin { get; set; }
	
	public string CustomData { get; set; }
}