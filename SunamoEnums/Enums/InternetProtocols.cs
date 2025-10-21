// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoEnums.Enums;

/// <summary>
/// Povolené internetové protokoly v GoShorteneru
/// </summary>
public enum InternetProtocols : byte
{
    Unknown = 0,
    http = 1,
    https = 2
}
