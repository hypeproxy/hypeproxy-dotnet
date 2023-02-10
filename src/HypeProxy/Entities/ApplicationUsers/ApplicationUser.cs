using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Microsoft.AspNetCore.Identity;
using Tapper;

namespace HypeProxy.Entities.ApplicationUsers;

[TranspilationSource]
public class ApplicationUser : IdentityUser<Guid>
{
	[JsonPropertyOrder(-2)]
	public override Guid Id { get; set; }

	[JsonPropertyOrder(-2)]
	public override string Email { get; set; }

	public string FullName { get; set; }
	
	public BillingDetails BillingDetails { get; set; }

	public DateTime RegistrationDateTime { get; set; }

	public string CultureConcern { get; set; }

	[PublicApiIgnore]
	public string StripeCustomerId { get; set; }

	[PublicApiIgnore]
	public int SecurityFlag { get; set; }

	[PublicApiIgnore]
	public string PasswordSignature { get; set; }

	[PublicApiIgnore]
	public string FingerprintId { get; set; }
	
	[PublicApiIgnore]
	public AuthorizationDetails Authorization { get; set; }
	
	[PublicApiIgnore]
	[JsonIgnore]
	public ConfidenceDetails Confidence { get; set; }

	public UserSettings Settings { get; set; }
	
	[PublicApiIgnore]
	public bool HadFirstLogin { get; set; }
	
	[PublicApiIgnore]
	public string CustomData { get; set; }
}