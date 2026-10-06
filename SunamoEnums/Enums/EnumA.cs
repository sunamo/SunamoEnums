namespace SunamoEnums.Enums;

// Flags allow an enum value to contain many values. An enum type with the [Flags] attribute
// can have multiple constant values assigned to it. It is still possible to test for these
// values in switches and if-statements.
[Flags]
public enum EnumA
{
    None = 0x0,
    All = 0x1,
    A = 0x2,
    B = 0x4,
    C = 0x8
}
