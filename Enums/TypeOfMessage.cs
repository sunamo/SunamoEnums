namespace
#if SunamoCl
SunamoCl
#elif SunamoLogging
SunamoLogging
#elif SunamoLogging
SunamoLogging
#elif SunamoLogging
SunamoLogging
#elif SunamoLogging
SunamoLogging
#elif SunamoLogging
SunamoLogging
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
SunamoEnums
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