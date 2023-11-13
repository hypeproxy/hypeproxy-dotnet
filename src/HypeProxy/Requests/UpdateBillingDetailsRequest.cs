using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to update the billing details for a user or company.
/// </summary>
[TranspilationSource]
public class UpdateBillingDetailsRequest
{
    /// <summary>
    /// The full name of the individual or contact person.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// The billing address.
    /// </summary>
    [Required]
    public string Address { get; set; }

    /// <summary>
    /// The zip or postal code.
    /// </summary>
    [Required]
    public string ZipCode { get; set; }

    /// <summary>
    /// The city of the billing address.
    /// </summary>
    [Required]
    public string City { get; set; }

    /// <summary>
    /// The country of the billing address.
    /// </summary>
    [Required]
    public string Country { get; set; }

    /// <summary>
    /// If the billing details are for a company.
    /// </summary>
    [Required(ErrorMessage = "LOL")]
    public bool IsCompany { get; set; }
    
    /// <summary>
    /// The name of the company.
    /// </summary>
    /// <remarks>Required if `IsCompany` is set to true.</remarks>
    [RequiredIfTrue(nameof(IsCompany))]
    public string? CompanyName { get; set; }

    /// <summary>
    /// The identification number of the company.
    /// </summary>
    /// <remarks>Required if `IsCompany` is set to true.</remarks>
    [RequiredIfTrue(nameof(IsCompany))]
    public string? CompanyIdentificationNumber { get; set; }

    /// <summary>
    /// The VAT number of the company.
    /// </summary>
    /// <remarks>Required if `IsCompany` is set to true.</remarks>
    public string? CompanyVatNumber { get; set; }

    /// <summary>
    /// The country where the company is located.
    /// </summary>
    /// <remarks>Required if `IsCompany` is set to true.</remarks>
    [RequiredIfTrue(nameof(IsCompany))]
    public string? CompanyCountry { get; set; }
}