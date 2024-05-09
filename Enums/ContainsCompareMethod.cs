namespace
#if SunamoCollections
SunamoCollections
#elif SunamoStringShared
SunamoStringShared
#else
SunamoEnumsEnums
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
