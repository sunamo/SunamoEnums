namespace
#if SunamoCollections
SunamoCollections
#elif SunamoStringShared
SunamoStringShared
#elif SunamoDevCode
SunamoDevCode
#elif SunamoString
SunamoString
#elif SunamoText
SunamoText
#elif SunamoStringData
SunamoStringData
#else
SunamoEnums
#endif
;
/// <summary>
/// Used in SunamoCollectionsGenericStore + SunamoCollections
/// </summary>
public enum ContainsCompareMethod
{
    WholeInput,
    SplitToWords,
    /// <summary>
    /// split to words and check for ! at [0]
    /// </summary>
    Negations
}