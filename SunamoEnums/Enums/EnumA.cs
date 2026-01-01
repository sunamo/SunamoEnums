// variables names: ok
namespace SunamoEnums.Enums;

/// <summary>
/// Flags enum allowing multiple values to be combined
/// </summary>
/// <remarks>
/// Flags allow an enum value to contain many values. An enum type with the [Flags] attribute
/// can have multiple constant values assigned to it. It is still possible to test for these
/// values in switches and if-statements.
/// </remarks>
[Flags]
public enum EnumA
{
    /// <summary>No flags set</summary>
    None = 0x0,
    /// <summary>All flags set</summary>
    All = 0x1,
    /// <summary>Flag A</summary>
    A = 0x2,
    /// <summary>Flag B</summary>
    B = 0x4,
    /// <summary>Flag C</summary>
    C = 0x8
}
