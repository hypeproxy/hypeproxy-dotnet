using System.Text.Json.Serialization;
using HypeProxy.Entities.Statuses;
using HypeProxy.Errors;
using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Provides a standardized API response.
/// </summary>
[TranspilationSource]
public class ApiResponse
{
    [JsonPropertyOrder(-2)]
    public string? Message { get; set; }

    [JsonPropertyOrder(-1)]
    public int StatusCode { get; set; }

    public object? Data { get; set; }

    public IEnumerable<ApiError> Errors { get; set; }

    public RequestDetail? RequestDetails { get; set; }
}