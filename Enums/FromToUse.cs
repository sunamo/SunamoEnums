namespace
#if SunamoCollectionsGenericShared
SunamoCollectionsGenericShared
#elif SunamoDateTime
SunamoDateTime
#elif SunamoCl
    SunamoCl
#else
SunamoEnumsEnums
#endif
;

public enum FromToUse
{
    DateTime,
    Unix,
    UnixJustTime,
    None
}
