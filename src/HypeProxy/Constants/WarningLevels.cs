using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

/// <summary>
/// Represents the different levels of warning or alert severity.
/// </summary>
[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WarningLevels
{
    /// <summary>
    /// Indicates an informational message, typically used for general messages that do not imply an error or problem.
    /// </summary>
    Information,

    /// <summary>
    /// Indicates a success message, commonly used to confirm that an action was completed successfully.
    /// </summary>
    Success,

    /// <summary>
    /// Indicates a warning message, used to highlight potential issues or to caution the user.
    /// </summary>
    Warning,

    /// <summary>
    /// Indicates a danger or high-severity message, often used for errors or critical issues that need immediate attention.
    /// </summary>
    Danger,

    /// <summary>
    /// Indicates a muted message, typically used for less important or lower priority information.
    /// </summary>
    Muted
}
