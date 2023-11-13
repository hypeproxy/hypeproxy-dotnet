using System.ComponentModel;
using System.Text.Json.Serialization;
using HypeProxy.Entities;

namespace HypeProxy.Infrastructure.Requests;

[EditorBrowsable(EditorBrowsableState.Never)]
public class PurchaseRequest
{
    /// <summary>
    /// Internal use only.
    /// </summary>
    [JsonIgnore]
    public Purchase? Purchase { get; set; }
}