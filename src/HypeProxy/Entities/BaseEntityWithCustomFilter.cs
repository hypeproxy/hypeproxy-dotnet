using System.ComponentModel.DataAnnotations.Schema;

namespace HypeProxy.Entities;

public class BaseEntityWithCustomFilter : BaseEntity
{
    [NotMapped]
    [Obsolete]
    public string PuteExpression { get; set; }
}