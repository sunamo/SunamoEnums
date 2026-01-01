// variables names: ok
namespace SunamoEnums.Enums;

// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
/// <summary>
///     Error/Warning are in tbLastErrorOrWarning, other in tbLastOtherMessage
///     Musí být zde kvůli cl které je withoutDep
/// </summary>
public enum TypeOfMessage
{
    /// <summary>
    ///     tbLastErrorOrWarning
    /// </summary>
    Error,
    /// <summary>
    ///     tbLastErrorOrWarning
    /// </summary>
    Warning,
    /// <summary>Information</summary>
    Information,
    /// <summary>
    ///     Returned if from text cant determine value
    /// </summary>
    Ordinal,
    /// <summary>Appeal</summary>
    Appeal,
    /// <summary>Success</summary>
    Success
}
