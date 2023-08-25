using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Define the billing details of a <see cref="User"/>.
/// </summary>
[TranspilationSource]
public partial class BillingDetails
{
	[Key]
	[PublicApiIgnore]
	[JsonIgnore]
	public Guid Id { get; set; }

    [Required]
	public string Address { get; set; }
    
    [Required]
	public string ZipCode { get; set; }
    
    [Required]
	public string City { get; set; }
    
    [Required]
	public string Country { get; set; }

	public bool IsCompany { get; set; }
	public string? CompanyName { get; set; }
	public string? CompanyIdentificationNumber { get; set; }
	public string? CompanyVatNumber { get; set; }
	public string? CompanyCountry { get; set; }
}

public partial class BillingDetails
{
    [JsonIgnore]
    public virtual User User { get; set; }
}