namespace SunamoEnums.Enums;

// Používá se pro mnoho serverů pro ukládání do DB, proto hodnotu žádné z těchto výčtových hodnot nemůžeš měnit,
// protože by ti pak nefungovala práce s DB
// In Long should have same first letter as in Short
// After every add/change call from HostingManager via SuMenuItem and open :\Sync\Develop of Future\Lists-Develop of
// Future\ - is here list with first letters
public enum MySites : byte
{
    //Ggdag = 0,
    BibleServer = 1,
    Cats = 2,
    GeoCaching = 3,
    Apps = 4,
    Photos = 5,
    Lyrics = 6,
    Developer = 7,
    // Hlavně neměň tuto hodnotu, neposouvej ji vždy až na poslední místo, protože  pak by nefungovala práce s DB, ve které(třeba v tabulce Pages) se používá i hodnota None
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
    Blogs = 20,
    Shop = 21,
    WindowsMetroControls = 22,
    None = 255
}
