using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Users;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Tickets;

/// <summary>
/// Defines the response to a ticket.
/// <see cref="Ticket"/>
/// </summary>
[TranspilationSource]
[Obsolete]
public partial class TicketAnswer : BaseEntityWithCustomFilter
{
    /// <summary>
    /// The unique identifier for the ticket answer.
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// The message content of the ticket answer.
    /// </summary>
    public string Message { get; set; }
    
    /// <summary>
    /// The date and time when the ticket answer was provided.
    /// </summary>
    public DateTime? AnsweredAt { get; set; }
}

public partial class TicketAnswer
{
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ForeignKey(nameof(Ticket))]
    public Guid TicketId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual Ticket Ticket { get; set; }
    
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    
    [JsonIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual User User { get; set; }
}