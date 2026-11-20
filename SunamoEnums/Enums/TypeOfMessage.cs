namespace SunamoEnums.Enums;

// Error/Warning are in tbLastErrorOrWarning, other in tbLastOtherMessage
// Must be here because of cl which is withoutDep
public enum TypeOfMessage
{
    // tbLastErrorOrWarning
    Error,
    // tbLastErrorOrWarning
    Warning,
    Information,
    // Returned if from text cant determine value
    Ordinal,
    Appeal,
    Success
}
