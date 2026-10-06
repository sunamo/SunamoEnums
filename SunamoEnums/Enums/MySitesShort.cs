namespace SunamoEnums.Enums;

public enum MySitesShort : byte
{
    //Ggd = 0,
    Bib = 1,
    Cts = 2,
    Geo = 3,
    App = 4,
    Phs = 5,
    Lyr = 6,
    Dev = 7,

    // Hlavně neměň tuto hodnotu, neposouvej ji vždy až na poslední místo, protože pak by nefungovala práce s DB, ve které(třeba v tabulce Pages) se používá i hodnota None
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

    // Honem to přelož aneb ChytreAplikace
    Htp = 17,
    Rps = 18,

    // Cant be Sda, one with same first letter there is (Sha)
    Yth = 19,
    /// <summary>None</summary>
    Blg = 20,
    Shp = 21,
    None = 255
}
