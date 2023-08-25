using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Errors;

/// <summary>
/// Describes an occured API error.
/// </summary>
[Obsolete]
[TranspilationSource]
public class ApiError
{
    public ApiErrorCode Code { get; set; }

    public string Description { get; set; }

    public ApiError()
    {
    }
    
    public ApiError(string code, string description = null)
    {
        Code = code;
        Description = description;
    }
    
    public ApiError(DefaultApiErrorCodes defaultApiErrorCode = DefaultApiErrorCodes.UnknownError, string description = null)
    {
        Code = ApiErrorCode.From(defaultApiErrorCode);
        Description = description;
    }
    
    public ApiError(string description = null) => Description = description;
}