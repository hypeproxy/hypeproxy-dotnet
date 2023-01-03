using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities.ApplicationUser;

[TranspilationSource]
public class BillingDetails
{
	[Key]
	[PublicApiIgnore]
	[JsonIgnore]
	public Guid Id { get; set; }

	public bool HasBillingDetailsDefined { get; set; }

	public string Address { get; set; }
	public string ZipCode { get; set; }
	public string City { get; set; }
	public string Country { get; set; }

	public bool IsCompany { get; set; }
	public string CompanyName { get; set; }
	public string CompanyIdentificationNumber { get; set; }
	public string CompanyVatNumber { get; set; }
	public string CompanyCountry { get; set; }
}