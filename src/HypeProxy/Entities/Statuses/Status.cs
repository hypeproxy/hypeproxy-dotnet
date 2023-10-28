using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities.Statuses;

/// <summary>
/// Define a status of an operation for a user.
/// </summary>
[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class Status : BaseEntityWithOwnership
{
    public string? Title { get; set; }
	public string? Message { get; set; }
    
    public Icons Icon { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(WarningLevels))]
	public WarningLevels Level { get; set; }
    
    [Obsolete]
    public bool IsAdministrator { get; set; }
    
    public Guid? RelatedEntity { get; set; }
    public string? RelatedEntityType { get; set; }
}

public partial class Status
{
    // [ForeignKey(nameof(User))]
    // [JsonIgnore]
    // public Guid UserId { get; set; }
    //
    // [JsonIgnore]
    // public virtual User User { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual RequestDetail? RequestDetails { get; set; }
}