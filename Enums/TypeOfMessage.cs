namespace
#if SunamoCl
SunamoCl
#elif SunamoLogger
SunamoLogger
#elif SunamoLogger
SunamoLogger
#elif SunamoLogger
SunamoLogger
#elif SunamoLogger
SunamoLogger
#elif SunamoLogger
SunamoLogger
#elif SunamoLogMessage
SunamoLogMessage
#elif SunamoLogMessage
SunamoLogMessage
#elif SunamoLogMessage
SunamoLogMessage
#elif SunamoShared
SunamoShared
#elif SunamoShared
SunamoShared
#elif SunamoShared
SunamoShared
#elif SunamoThisApp
SunamoThisApp
#elif SunamoThisApp
SunamoThisApp
#elif SunamoThisApp
SunamoThisApp
#elif SunamoEnums
SunamoEnums
#elif SunamoData
SunamoData
#else
SunamoTypeOfMessage
#endif
;
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
    Information,
    /// <summary>
    ///     Returned if from text cant determine value
    /// </summary>
    Ordinal,
    Appeal,
    Success
}