using Tapper;

namespace HypeProxy.Entities;

[TranspilationSource]
public class Memo : BaseEntity
{
    public string Message { get; set; }
    
    public static implicit operator string(Memo d) => d.Message;
    public static implicit operator Memo(string d) => new() { Message = d };
}