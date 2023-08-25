using System.Text.Json.Serialization;
using HypeProxy.Entities.Statuses;
using HypeProxy.Errors;
using HypeProxy.Requests;
using Tapper;

namespace HypeProxy.Responses;

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

    public IEnumerable<ApiError> Errors { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RequestDetail RequestDetails { get; set; }
}


// public class ApiResponse<T> : ApiResponse
// {
//     public new T Data { get; set; }
// }