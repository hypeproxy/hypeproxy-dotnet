using System.ComponentModel;
using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Infrastructure.Entities;
using Tapper;

namespace HypeProxy.Entities.Statuses;

/// <summary>
/// Represents a status of an operation for a user.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class Status : BaseEntityWithOwnership
{
    public string? Title { get; set; }
	public string? Message { get; set; }
    
    public Icons Icon { get; set; }
    
	public WarningLevels Level { get; set; }
    
    // TODO: Check if obsolete or not
    // [Obsolete]
    // public bool IsAdministrator { get; set; }
    //
    // public Guid? RelatedEntity { get; set; }
    // public string? RelatedEntityType { get; set; }
}

public partial class Status
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual RequestDetail? RequestDetails { get; set; }
}