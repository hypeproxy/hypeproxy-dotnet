using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities.Tickets;

/// <summary>
/// Defines a user's `Ticket`.
/// </summary>
[TranspilationSource]
public partial class Ticket : BaseEntityWithOwnership
{
    public string Subject { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(TicketPriorities))]
    public TicketPriorities Priority { get; set; }

	[PublicApiIgnore]
	public string? Category { get; set; }

	public string Message { get; set; }
    
	public bool IsClosed { get; set; }
}

public partial class Ticket
{
    [ForeignKey(nameof(Purchase))]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Guid? PurchaseId { get; set; }
    
    [JsonIgnore]
    public virtual Purchase? Purchase { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<TicketAnswer> Answers { get; set; }
}
