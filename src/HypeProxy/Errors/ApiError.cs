using Tapper;

namespace HypeProxy.Errors;

/// <summary>
/// Represents an API error.
/// </summary>
[TranspilationSource]
public class ApiError
{
    /// <summary>
    /// The error code associated with the API error.
    /// Should be contained in <see cref="ApiErrorCodes"/>.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// (Optional) A description providing additional information about the API error.
    /// </summary>
    public string? Description { get; set; }

    public ApiError(string code)
    {
        Code = code;
    }
    
    public ApiError(string code, string? description = null)
    {
        Code = code;
        Description = description;
    }
}