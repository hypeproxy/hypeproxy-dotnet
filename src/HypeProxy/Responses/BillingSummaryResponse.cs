using Tapper;

namespace HypeProxy.Responses;

/// <summary>
/// Represents a response containing a summary of billing information.
/// </summary>
[TranspilationSource]
public class BillingSummaryResponse
{
    /// <summary>
    /// Represents the monthly costs. 
    /// </summary>
    public double? MonthlyCosts { get; set; }
}