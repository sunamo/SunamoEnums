namespace SunamoEnums.Enums;

// Used in SunamoCollectionsGenericStore + SunamoCollections
public enum ContainsCompareMethod
{
    WholeInput,
    SplitToWords,
    // split to words and check for ! at [0]
    Negations
}
