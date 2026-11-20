namespace SunamoEnums.Enums;

// Used in SunamoCollectionsGenericStore + SunamoCollections
/// <summary>
/// Represents the contains compare method type.
/// </summary>
public enum ContainsCompareMethod
{
    /// <summary>
    /// The whole input value.
    /// </summary>
    WholeInput,
    /// <summary>
    /// The split to words value.
    /// </summary>
    SplitToWords,
    // split to words and check for ! at [0]
    /// <summary>
    /// The negations value.
    /// </summary>
    Negations
}
