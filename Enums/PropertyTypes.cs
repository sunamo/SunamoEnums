namespace
#if SunamoConverters
SunamoConverters
#else
SunamoEnums
#endif
;
PropertyTypes
/// <summary>
/// Po novu už žádná třída nemůže končit 2
/// Přejmenoval jsem z PropertyType2 na PropertyTypes
/// Doufám že to nebude s ničím kolidovat
/// </summary>
public enum PropertyType2
{
    ULong,
    UInt,
    UShort,
    Byte,
    String,
    Double,
    Float,
    DateTime,
    Bool,
    ByteArray
}