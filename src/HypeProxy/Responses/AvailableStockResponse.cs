using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response containing information about the available stock of a product or item.
/// </summary>
[TranspilationSource]
public class AvailableStockResponse
{
    /// <summary>
    /// An integer representing the available quantity of the item or product in stock.
    /// </summary>
    public int AvailableQuantity { get; set; }
}