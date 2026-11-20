namespace SunamoEnums.Enums;

// Flags allow an enum value to contain many values. An enum type with the [Flags] attribute
// can have multiple constant values assigned to it. It is still possible to test for these
// values in switches and if-statements.
/// <summary>
/// Represents the enum a type.
/// </summary>
[Flags]
public enum EnumA
{
    /// <summary>
    /// The none value.
    /// </summary>
    None = 0x0,
    /// <summary>
    /// The all value.
    /// </summary>
    All = 0x1,
    /// <summary>
    /// The a value.
    /// </summary>
    A = 0x2,
    /// <summary>
    /// The b value.
    /// </summary>
    B = 0x4,
    /// <summary>
    /// The c value.
    /// </summary>
    C = 0x8
}
