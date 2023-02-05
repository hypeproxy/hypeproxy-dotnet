using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Converters;
using Tapper;

namespace HypeProxy.Responses.Base;

/// <summary>
/// Describes an occured API error.
/// </summary>
[TranspilationSource]
public class ApiError
{
    [JsonConverter(typeof(ApiErrorCodeConverter))]
    public ApiErrorCode Code { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    public ApiError()
    {
    }
    
    public ApiError(ApiErrorCode code, string description = null)
    {
        Code = code;
        Description = description;
    }
    
    public ApiError(ApiErrorCodes code = ApiErrorCodes.UnknownError, string description = null)
    {
        Code = code;
        Description = description;
    }
}