namespace SunamoEnums.Enums;

/// <summary>
///     Používá se pro mnoho serverů pro ukládání do DB, proto hodnotu žádné z těchto výčtových hodnot nemůžeš měnit,
///     protože by ti pak nefungovala práce s DB
///     In Long should have same first letter as in Short
///     After every add/change call from HostingManager via SuMenuItem and open :\Sync\Develop of Future\Lists-Develop of
///     Future\ - is here list with first letters
/// </summary>
public enum MySites : byte
{
    //Ggdag = 0,
    /// <summary>BibleServer</summary>
    BibleServer = 1,
    /// <summary>Cats</summary>
    Cats = 2,
    /// <summary>GeoCaching</summary>
    GeoCaching = 3,
    /// <summary>Apps</summary>
    Apps = 4,
    /// <summary>Photos</summary>
    Photos = 5,
    /// <summary>Lyrics</summary>
    Lyrics = 6,
    /// <summary>Developer</summary>
    Developer = 7,
    // Hlavně neměň tuto hodnotu, neposouvej ji vždy až na poslední místo, protože  pak by nefungovala práce s DB, ve které(třeba v tabulce Pages) se používá i hodnota None
    /// <summary>Nope</summary>
    Nope = 8,
    /// <summary>Calc</summary>
    Calc = 9,
    /// <summary>ThunderBrigade</summary>
    ThunderBrigade = 10,
    /// <summary>Youth</summary>
    Youth = 11,
    /// <summary>Shortener</summary>
    Shortener = 12,
    /// <summary>Shared</summary>
    Shared = 13,
    /// <summary>Eurostrip</summary>
    Eurostrip = 14,
    /// <summary>Widgets</summary>
    Widgets = 15,
    /// <summary>Dart</summary>
    Dart = 16,
    /// <summary>AppsCs</summary>
    AppsCs = 17,
    /// <summary>RepairService</summary>
    RepairService = 18,
    /// <summary>
    ///     Cant be Sda, one with same first letter there is in short
    ///     When I delete here, must delete also from mss. otherwise when I use continue; and convert from mss and ms,
    ///     continue; here wont find fight enum
    /// </summary>
    Adventist = 19,
    /// <summary>None</summary>
    None = 255
}