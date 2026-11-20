namespace SunamoEnums.Enums;

public enum MySitesShort : byte
{
    Bib = 1,
    Cts = 2,
    Geo = 3,
    App = 4,
    Phs = 5,
    Lyr = 6,
    Dev = 7,

    // Above all, do not change this value and do not always move it to the last position, because then working with the DB would break, where (e.g. in the Pages table) the value None is also used
    Nope = 8,

    // Cant be clc due to Cts
    Mth = 9,
    TBG = 10,
    Fth = 11,
    Sho = 12,
    Sha = 13,
    Eur = 14,
    Wid = 15,
    Var = 16,

    // Translate it quickly
    Htp = 17,
    Rps = 18,

    // Cant be Sda, one with same first letter there is (Sha)
    Yth = 19,
    /// <summary>None</summary>
    Blg = 20,
    Shp = 21,
    None = 255
}
