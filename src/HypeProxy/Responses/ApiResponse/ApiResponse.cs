using System.Text.Json.Serialization;
using Tapper;

// ReSharper disable MemberCanBePrivate.Global

namespace HypeProxy.Responses.ApiResponse;

/// <summary>
/// Provides a standardized API response.
/// </summary>
[TranspilationSource]
public class ApiResponse
{
    [JsonPropertyOrder(-2)]
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