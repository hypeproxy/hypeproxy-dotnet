using System.Text.Json.Serialization;
using HypeProxy.Entities;

namespace HypeProxy.Requests;

public class PurchaseRequest
{
    /// <summary>
    /// Internal use only.
    /// </summary>
    [JsonIgnore]
    public Purchase? Purchase { get; set; }
}