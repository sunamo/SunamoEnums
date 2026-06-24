namespace SunamoEnums.Enums;

// Pro rychlé zjištění můžeš používat i metody UniversalInterop, vhodné zejména v případě že aplikace se ovládá např. gesty prstů
// Vždy se jedná o delší stranu displeje
// Pokud některá app tyto rozměny změní, musí to být zaznamenáno zde pro snadné porovnání a přehled
// Každá aplikace může mít jiné minimální rozměry pro danou hodnotu
public enum ScreenSize
{
    // Telefon, Nad 0
    Small,
    // Tablet(spadne tu i většina notebooků a PC), nad 1279
    Medium,
    // Extrémní PC, Notebook, Nad 1919
    Large
}
