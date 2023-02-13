using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Converters;
using Tapper;

namespace HypeProxy.Errors;

[TranspilationSource]
[JsonConverter(typeof(ApiErrorCodeConverter))]
public class ApiErrorCode
{
    private readonly string _value;
    public ApiErrorCode(string value) => _value = value;
    
    public static implicit operator string(ApiErrorCode d) => d._value;
    public static implicit operator ApiErrorCode(string d) => new(d);
    
    public static string From(DefaultApiErrorCodes apiErrorCode) => new ApiErrorCode(apiErrorCode.ToString());

    protected internal string GetValue() => _value;
}