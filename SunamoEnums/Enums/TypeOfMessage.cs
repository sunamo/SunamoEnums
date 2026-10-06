namespace SunamoEnums.Enums;

// Error/Warning are in tbLastErrorOrWarning, other in tbLastOtherMessage
// Musí být zde kvůli cl které je withoutDep
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
