using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using HypeProxy.Attributes;
using HypeProxy.Entities.Users;
using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class Memo : BaseEntityWithOwnership
{
    /// <summary>
    /// Message to store.
    /// </summary>
    public string Message { get; set; }
}

public partial class Memo
{
    public static implicit operator string(Memo d) => d.Message;
    public static implicit operator Memo(string d) => new() { Message = d };
}