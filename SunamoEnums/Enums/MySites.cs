namespace SunamoEnums.Enums;

// It is used by many servers for saving to the DB, so you cannot change the value of any of these enum members,
// because working with the DB would not work for you then
// In Long should have same first letter as in Short
// After every add/change call from HostingManager via SuMenuItem and open :\Sync\Develop of Future\Lists-Develop of
// Future\ - is here list with first letters
public enum MySites : byte
{
    BibleServer = 1,
    Cats = 2,
    GeoCaching = 3,
    Apps = 4,
    Photos = 5,
    Lyrics = 6,
    Developer = 7,
    // Above all, do not change this value and do not always move it to the last position, because then working with the DB would break, where (e.g. in the Pages table) the value None is also used
    Nope = 8,
    Calc = 9,
    ThunderBrigade = 10,
    Youth = 11,
    Shortener = 12,
    Shared = 13,
    Eurostrip = 14,
    Widgets = 15,
    Dart = 16,
    AppsCs = 17,
    RepairService = 18,
    // Cant be Sda, one with same first letter there is in short
    // When I delete here, must delete also from mss. otherwise when I use continue; and convert from mss and ms,
    // continue; here wont find fight enum
    Adventist = 19,
    /// <summary>None</summary>
    Blogs = 20,
    Shop = 21,
    WindowsMetroControls = 22,
    None = 255
}
