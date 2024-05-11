
namespace SunamoEnums;
sunamoWithoutLocalDep
#if SunamoCollectionsGenericShared
SunamoCollectionsGenericShared
#elif SunamoDateTime
SunamoDateTime
#elif SunamoCl
    SunamoCl
#elif SunamoCollections
SunamoCollections
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