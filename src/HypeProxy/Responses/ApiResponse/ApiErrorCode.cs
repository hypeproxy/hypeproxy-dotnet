using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Responses.ApiResponse;

[TranspilationSource]
public class ApiErrorCode
{
    private readonly string _value;
    
    public ApiErrorCode(string value) => _value = value;
    public ApiErrorCode(ApiErrorCodes errorCode) => _value = errorCode.ToString();
    public ApiErrorCode(FailedValidationReasons validationReason) => _value = validationReason.ToString();
    
    public static implicit operator ApiErrorCodes(ApiErrorCode d) => Enum.Parse<ApiErrorCodes>(d._value);
    public static implicit operator ApiErrorCode(ApiErrorCodes d) => new(d);
    
    public static implicit operator FailedValidationReasons(ApiErrorCode d) => Enum.Parse<FailedValidationReasons>(d._value);
    public static implicit operator ApiErrorCode(FailedValidationReasons d) => new(d);
    
    public static implicit operator string(ApiErrorCode d) => d._value;
    public static implicit operator ApiErrorCode(string d) => new(d);

    public static string From(ApiErrorCodes errorCode) => new ApiErrorCode(errorCode);
    public static string From(FailedValidationReasons validationReason) => new ApiErrorCode(validationReason);
}