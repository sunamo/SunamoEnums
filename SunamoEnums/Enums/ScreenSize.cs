namespace SunamoEnums.Enums;

// For a quick check you can also use the UniversalInterop methods, suitable especially when the application is controlled e.g. by finger gestures
// It is always the longer side of the display
// If any app changes these dimensions, it must be recorded here for easy comparison and overview
// Each application can have different minimum dimensions for the given value
public enum ScreenSize
{
    // Telefon, Nad 0
    Small,
    // Tablet (most laptops and PCs fall here too), above 1279
    Medium,
    // Extreme PC, Notebook, Over 1919
    Large
}
