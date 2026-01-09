// variables names: ok
namespace SunamoEnums.Enums;

/// <summary>
/// Used in SunamoCollectionsGenericStore + SunamoCollections
/// </summary>
public enum ContainsCompareMethod
{
    /// <summary>WholeInput</summary>
    WholeInput,
    /// <summary>SplitToWords</summary>
    SplitToWords,
    /// <summary>
    /// split to words and check for ! at [0]
    /// </summary>
    Negations
}
