namespace SunamoEnums.Enums;

/// <summary>
/// Represents the my sites short type.
/// </summary>
public enum MySitesShort : byte
{
    /// <summary>
    /// The bib value.
    /// </summary>
    Bib = 1,
    /// <summary>
    /// The cts value.
    /// </summary>
    Cts = 2,
    /// <summary>
    /// The geo value.
    /// </summary>
    Geo = 3,
    /// <summary>
    /// The app value.
    /// </summary>
    App = 4,
    /// <summary>
    /// The phs value.
    /// </summary>
    Phs = 5,
    /// <summary>
    /// The lyr value.
    /// </summary>
    Lyr = 6,
    /// <summary>
    /// The dev value.
    /// </summary>
    Dev = 7,

    // Above all, do not change this value and do not always move it to the last position, because then working with the DB would break, where (e.g. in the Pages table) the value None is also used
    /// <summary>
    /// The nope value.
    /// </summary>
    Nope = 8,

    // Cant be clc due to Cts
    /// <summary>
    /// The mth value.
    /// </summary>
    Mth = 9,
    /// <summary>
    /// The TBG value.
    /// </summary>
    TBG = 10,
    /// <summary>
    /// The fth value.
    /// </summary>
    Fth = 11,
    /// <summary>
    /// The sho value.
    /// </summary>
    Sho = 12,
    /// <summary>
    /// The sha value.
    /// </summary>
    Sha = 13,
    /// <summary>
    /// The eur value.
    /// </summary>
    Eur = 14,
    /// <summary>
    /// The wid value.
    /// </summary>
    Wid = 15,
    /// <summary>
    /// The var value.
    /// </summary>
    Var = 16,

    // Translate it quickly
    /// <summary>
    /// The htp value.
    /// </summary>
    Htp = 17,
    /// <summary>
    /// The rps value.
    /// </summary>
    Rps = 18,

    // Cant be Sda, one with same first letter there is (Sha)
    /// <summary>
    /// The yth value.
    /// </summary>
    Yth = 19,
    /// <summary>None</summary>
    Blg = 20,
    /// <summary>
    /// The shp value.
    /// </summary>
    Shp = 21,
    /// <summary>
    /// The none value.
    /// </summary>
    None = 255
}
