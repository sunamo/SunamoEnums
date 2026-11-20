namespace SunamoEnums.Enums;

// It is used by many servers for saving to the DB, so you cannot change the value of any of these enum members,
// because working with the DB would not work for you then
// In Long should have same first letter as in Short
// After every add/change call from HostingManager via SuMenuItem and open :\Sync\Develop of Future\Lists-Develop of
// Future\ - is here list with first letters
/// <summary>
/// Represents the my sites type.
/// </summary>
public enum MySites : byte
{
    /// <summary>
    /// The bible server value.
    /// </summary>
    BibleServer = 1,
    /// <summary>
    /// The cats value.
    /// </summary>
    Cats = 2,
    /// <summary>
    /// The geo caching value.
    /// </summary>
    GeoCaching = 3,
    /// <summary>
    /// The apps value.
    /// </summary>
    Apps = 4,
    /// <summary>
    /// The photos value.
    /// </summary>
    Photos = 5,
    /// <summary>
    /// The lyrics value.
    /// </summary>
    Lyrics = 6,
    /// <summary>
    /// The developer value.
    /// </summary>
    Developer = 7,
    // Above all, do not change this value and do not always move it to the last position, because then working with the DB would break, where (e.g. in the Pages table) the value None is also used
    /// <summary>
    /// The nope value.
    /// </summary>
    Nope = 8,
    /// <summary>
    /// The calc value.
    /// </summary>
    Calc = 9,
    /// <summary>
    /// The thunder brigade value.
    /// </summary>
    ThunderBrigade = 10,
    /// <summary>
    /// The youth value.
    /// </summary>
    Youth = 11,
    /// <summary>
    /// The shortener value.
    /// </summary>
    Shortener = 12,
    /// <summary>
    /// The shared value.
    /// </summary>
    Shared = 13,
    /// <summary>
    /// The eurostrip value.
    /// </summary>
    Eurostrip = 14,
    /// <summary>
    /// The widgets value.
    /// </summary>
    Widgets = 15,
    /// <summary>
    /// The dart value.
    /// </summary>
    Dart = 16,
    /// <summary>
    /// The apps cs value.
    /// </summary>
    AppsCs = 17,
    /// <summary>
    /// The repair service value.
    /// </summary>
    RepairService = 18,
    // Cant be Sda, one with same first letter there is in short
    // When I delete here, must delete also from mss. otherwise when I use continue; and convert from mss and ms,
    // continue; here wont find fight enum
    /// <summary>
    /// The adventist value.
    /// </summary>
    Adventist = 19,
    /// <summary>None</summary>
    Blogs = 20,
    /// <summary>
    /// The shop value.
    /// </summary>
    Shop = 21,
    /// <summary>
    /// The windows metro controls value.
    /// </summary>
    WindowsMetroControls = 22,
    /// <summary>
    /// The none value.
    /// </summary>
    None = 255
}
