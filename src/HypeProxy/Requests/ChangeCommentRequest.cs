using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class ChangeCommentRequest
{
    public string Message { get; set; }
}