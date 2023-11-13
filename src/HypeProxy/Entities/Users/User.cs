using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Entities.Statuses;
using HypeProxy.Entities.Tickets;
using Microsoft.AspNetCore.Identity;
using Tapper;

namespace HypeProxy.Entities.Users;

/// <summary>
/// Represents an HypeProxy.io user.
/// </summary>
[TranspilationSource]
public partial class User : IdentityUser<Guid>
{
    /// <summary>
    /// The user's unique identifier.
    /// </summary>
    [JsonPropertyOrder(-2)]
	public override Guid Id { get; set; }

    /// <summary>
    /// The user's email address.
    /// </summary>
	[JsonPropertyOrder(-2)]
	public override string Email { get; set; }

    /// <summary>
    /// The user's full name.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// The date and time when the user was registered.
    /// </summary>
	public DateTime RegisteredAt { get; set; }
    
    /// <summary>
    /// The Stripe customer Id associated with the user. 
    /// </summary>
    [PublicApiIgnore]
    public string? StripeCustomerId { get; set; }
}

public partial class User
{
    /// <summary>
    /// The billing details Id.
    /// </summary>
    [ForeignKey(nameof(BillingDetails))]
    public Guid? BillingDetailsId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual BillingDetails? BillingDetails { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual UserSettings? Settings { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual AuthorizationDetails? Authorization { get; set; }
	
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ComplianceDetails? Compliance { get; set; }
}

public partial class User
{
    // public virtual ICollection<Invoice> Invoices { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Purchase> Purchases { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Notification> Notifications { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Memo> Memos { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Reminder> Reminders { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Status> Statuses { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<Ticket> Tickets { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<TicketAnswer> TicketAnswers { get; set; }
}

public partial class User
{
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? CultureConcern { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int SecurityFlag { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? PasswordSignature { get; set; }

    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? FingerprintId { get; set; }
	
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string? CustomData { get; set; }
	
    [PublicApiIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool HadFirstLogin { get; set; }
}
