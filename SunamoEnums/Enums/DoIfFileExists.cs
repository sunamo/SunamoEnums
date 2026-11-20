namespace SunamoEnums.Enums;

/// <summary>
/// Represents the do if file exists type.
/// </summary>
public enum DoIfFileExists
{
    // Will not add anything
    /// <summary>
    /// The overwrite value.
    /// </summary>
    Overwrite,
    // Keeps the existing file, the new content is discarded
    /// <summary>
    /// The do nothing value.
    /// </summary>
    DoNothing
}
