using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeBillingDetailsRequest
{
    public string FullName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string ZipCode { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string Country { get; set; }

    [Required(ErrorMessage = "LOL")]
    public bool IsCompany { get; set; }

    [RequiredIfTrue(nameof(IsCompany))]
    public string CompanyName { get; set; }

    [RequiredIfTrue(nameof(IsCompany))]
    public string CompanyIdentificationNumber { get; set; }

    [RequiredIfTrue(nameof(IsCompany))]
    public string CompanyVatNumber { get; set; }

    [RequiredIfTrue(nameof(IsCompany))]
    public string CompanyCountry { get; set; }
}