using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities.Tickets;

/// <summary>
/// Defines the response to a <see cref="Ticket"/>.
/// </summary>
[TranspilationSource]
public partial class TicketAnswer : BaseEntityWithCustomFilter
{
    [Key]
    public Guid Id { get; set; }
    
    public string Message { get; set; }
    
    public DateTime? AnsweredAt { get; set; }
}

public partial class TicketAnswer
{
    [JsonIgnore]
    [ForeignKey(nameof(Ticket))]
    public Guid TicketId { get; set; }
    
    [JsonIgnore]
    public virtual Ticket Ticket { get; set; }
    
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    
    [JsonIgnore]
    public virtual User User { get; set; }
}