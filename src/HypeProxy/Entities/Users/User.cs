using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Entities.Statuses;
using HypeProxy.Entities.Tickets;
using Microsoft.AspNetCore.Identity;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Defines a user of our service.
/// </summary>
[TranspilationSource]
public partial class User : IdentityUser<Guid>
{
    [JsonPropertyOrder(-2)]
	public override Guid Id { get; set; }

	[JsonPropertyOrder(-2)]
	public override string Email { get; set; }

    public string FullName { get; set; }

	public DateTime RegisteredAt { get; set; }
    
    [PublicApiIgnore]
    public string? StripeCustomerId { get; set; }
}

public partial class User
{
    [ForeignKey(nameof(BillingDetails))]
    public Guid? BillingDetailsId { get; set; }
    
    [JsonIgnore]
    public virtual BillingDetails? BillingDetails { get; set; }
    
    [JsonIgnore]
    public virtual UserSettings? Settings { get; set; }
    
    [JsonIgnore]
    public virtual AuthorizationDetails? Authorization { get; set; }
	
    [JsonIgnore]
    public virtual ComplianceDetails? Compliance { get; set; }
}

public partial class User
{
    // public virtual ICollection<Invoice> Invoices { get; set; }
    public virtual ICollection<Purchase> Purchases { get; set; }
    public virtual ICollection<Notification> Notifications { get; set; }
    public virtual ICollection<Memo> Memos { get; set; }
    public virtual ICollection<Reminder> Reminders { get; set; }
    public virtual ICollection<Status> Statuses { get; set; }
    public virtual ICollection<Ticket> Tickets { get; set; }
    public virtual ICollection<TicketAnswer> TicketAnswers { get; set; }
}

public partial class User
{
    [PublicApiIgnore]
    public string? CultureConcern { get; set; }

    [PublicApiIgnore]
    public int SecurityFlag { get; set; }

    [PublicApiIgnore]
    public string? PasswordSignature { get; set; }

    [PublicApiIgnore]
    public string? FingerprintId { get; set; }
	
    [PublicApiIgnore]
    public string? CustomData { get; set; }
	
    [PublicApiIgnore]
    public bool HadFirstLogin { get; set; }
}
