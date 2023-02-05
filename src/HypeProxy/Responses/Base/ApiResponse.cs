using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Responses.Base;

/// <summary>
/// Provides a standardized API response.
/// </summary>
[TranspilationSource]
public class ApiResponse
{
    [JsonPropertyOrder(-2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Message { get; set; }

    [JsonPropertyOrder(-1)]
    public int StatusCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object Data { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<ApiError> Errors { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RequestDetails RequestDetails { get; set; }
}