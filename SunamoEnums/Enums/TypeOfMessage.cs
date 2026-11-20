namespace SunamoEnums.Enums;

// Error/Warning are in tbLastErrorOrWarning, other in tbLastOtherMessage
// Must be here because of cl which is withoutDep
/// <summary>
/// Represents the type of message type.
/// </summary>
public enum TypeOfMessage
{
    // tbLastErrorOrWarning
    /// <summary>
    /// The error value.
    /// </summary>
    Error,
    // tbLastErrorOrWarning
    /// <summary>
    /// The warning value.
    /// </summary>
    Warning,
    /// <summary>
    /// The information value.
    /// </summary>
    Information,
    // Returned if from text cant determine value
    /// <summary>
    /// The ordinal value.
    /// </summary>
    Ordinal,
    /// <summary>
    /// The appeal value.
    /// </summary>
    Appeal,
    /// <summary>
    /// The success value.
    /// </summary>
    Success
}
