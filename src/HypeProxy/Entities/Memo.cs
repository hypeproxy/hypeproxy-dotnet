using System.ComponentModel;
using HypeProxy.Infrastructure.Entities;
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
    public static implicit operator string(Memo memo) => memo.Message;
    public static implicit operator Memo(string message) => new() { Message = message };
}