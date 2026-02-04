namespace SunamoEnums.Enums;

/// <summary>
///     Every web should start with unique letter - checked by AddSpaceAfterFirstLetterForEveryAndSort -
///     Používá se pro mnoho serverů pro ukládání do DB, proto hodnotu žádné z těchto výčtových hodnot nemůžeš měnit,
///     protože by ti pak nefungovala práce s DB
///     In Short must have every entry first letter unique
///     After every add/change call from HostingManager via SuMenuItem and open :\Sync\Develop of Future\Lists-Develop of
///     Future\ - is here list with first letters
/// </summary>
public enum MySitesShort : byte
{
    //Ggd = 0,
    /// <summary>Bib</summary>
    Bib = 1,
    /// <summary>Cts</summary>
    Cts = 2,
    /// <summary>Geo</summary>
    Geo = 3,
    /// <summary>App</summary>
    App = 4,
    /// <summary>Phs</summary>
    Phs = 5,
    /// <summary>Lyr</summary>
    Lyr = 6,
    /// <summary>Dev</summary>
    Dev = 7,

    // Hlavně neměň tuto hodnotu, neposouvej ji vždy až na poslední místo, protože pak by nefungovala práce s DB, ve které(třeba v tabulce Pages) se používá i hodnota None
    /// <summary>Nope</summary>
    Nope = 8,

    // Cant be clc due to Cts
    /// <summary>Mth</summary>
    Mth = 9,
    /// <summary>TBG</summary>
    TBG = 10,
    /// <summary>Fth</summary>
    Fth = 11,
    /// <summary>Sho</summary>
    Sho = 12,
    /// <summary>Sha</summary>
    Sha = 13,
    /// <summary>Eur</summary>
    Eur = 14,
    /// <summary>Wid</summary>
    Wid = 15,
    /// <summary>Var</summary>
    Var = 16,

    /// <summary>
    ///     Honem to přelož aneb ChytreAplikace
    /// </summary>
    Htp = 17,
    /// <summary>Rps</summary>
    Rps = 18,

    /// <summary>
    ///     Cant be Sda, one with same first letter there is (Sha)
    /// </summary>
    Yth = 19,
    /// <summary>None</summary>
    None = 255
}