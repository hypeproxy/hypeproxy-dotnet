using System.ComponentModel.DataAnnotations;

namespace HypeProxy.Requests;

public class CreateMemoRequest
{
    [Required]
    public string Message { get; set; }
}