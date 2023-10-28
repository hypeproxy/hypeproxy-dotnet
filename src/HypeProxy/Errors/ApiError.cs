using Tapper;

namespace HypeProxy.Errors;

/// <summary>
/// Describes an occured API error.
/// </summary>
[TranspilationSource]
public class ApiError
{
    public string Code { get; set; }

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