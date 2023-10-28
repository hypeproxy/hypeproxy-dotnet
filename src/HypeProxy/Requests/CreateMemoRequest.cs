using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

[TranspilationSource]
public class CreateMemoRequest
{
    [Required]
    public string Message { get; set; }
}