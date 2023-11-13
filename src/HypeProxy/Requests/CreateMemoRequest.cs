using System.ComponentModel.DataAnnotations;
using Tapper;

namespace HypeProxy.Requests;

/// <summary>
/// Represents a request to create a new memo.
/// </summary>
[TranspilationSource]
public class CreateMemoRequest
{
    /// <summary>
    /// The message content for the memo.
    /// </summary>
    [Required]
    public string Message { get; set; }
}