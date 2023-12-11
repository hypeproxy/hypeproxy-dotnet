using System.Text.Json.Serialization;
using HypeProxy.Entities.Statuses;
using HypeProxy.Errors;
using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Provides a standardized API response.
/// </summary>
/// <remarks>
/// This class is designed to standardize the structure of responses sent from the API, including status codes, messages, data, and any errors.
/// </remarks>
[TranspilationSource]
public class ApiResponse
{
    /// <summary>
    /// A message string. It can be null if no additional message is provided.
    /// </summary>
    [JsonPropertyOrder(-2)]
    public string? Message { get; set; }

    /// <summary>
    /// An integer representing the HTTP status code.
    /// </summary>
    [JsonPropertyOrder(-1)]
    public int StatusCode { get; set; }

    /// <summary>
    /// The data object. It can be null if no data is to be returned.
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// A collection of <see cref="ApiError"/> objects.
    /// </summary>
    public IEnumerable<ApiError> Errors { get; set; }

    /// <summary>
    /// An instance of <see cref="Entities.Statuses.RequestDetails"/> providing details about the request. It can be null.
    /// </summary>
    public RequestDetails? RequestDetails { get; set; }
}

/// <summary>
/// Represents a standardized API response with a specific data type.
/// </summary>
/// <typeparam name="TEntity">The type of the data payload in the API response.</typeparam>
public abstract class ApiResponse<TEntity> : ApiResponse
{
    /// <summary>
    /// The data object of type <typeparamref name="TEntity"/>. It can be null if no data is to be returned.
    /// </summary>
    public new TEntity? Data { get; set; }
}