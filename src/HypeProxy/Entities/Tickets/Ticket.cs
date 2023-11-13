using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Tickets;

/// <summary>
/// Defines a user's ticket.
/// </summary>
[TranspilationSource]
public partial class Ticket : BaseEntityWithOwnership
{
	/// <summary>
	/// The subject of the ticket.
	/// </summary>
    public string Subject { get; set; }
    
	/// <summary>
	/// The priority of the ticket.
	/// </summary>
    public TicketPriorities Priority { get; set; }

	[PublicApiIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string? Category { get; set; }

	/// <summary>
	/// The message content of the ticket.
	/// </summary>
	public string Message { get; set; }
    
	/// <summary>
	/// Indicates whether the ticket is closed.
	/// </summary>
	public bool IsClosed { get; set; }
}

public partial class Ticket
{
	/// <summary>
	/// The purchase Id associated with the ticket
	/// </summary>
    [ForeignKey(nameof(Purchase))]
    public Guid? PurchaseId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Purchase? Purchase { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ICollection<TicketAnswer> Answers { get; set; }
}
