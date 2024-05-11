namespace
#if SunamoBts
SunamoBts
#elif SunamoArgs
    SunamoArgs
#elif SunamoFtp
SunamoFtp
#else
SunamoEnumsEnums
#endif
;

/// <summary>
/// Zkratka pro SignedUnsigned
/// </summary>
public enum Signed
{
    Signed,
    Unsigned,
    Other
}
