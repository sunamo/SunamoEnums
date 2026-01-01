namespace SunamoEnums._sunamo.SunamoExceptions;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
// © www.sunamo.cz. All Rights Reserved.

/// <summary>
/// Helper class for exception handling and formatting
/// </summary>
internal sealed partial class Exceptions
{
    #region Other

#region IsNullOrWhitespace
    /// <summary>
    /// StringBuilder for inner additional info
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoInnerStringBuilder = new();

    /// <summary>
    /// StringBuilder for additional info
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoStringBuilder = new();
    #endregion
#endregion
}