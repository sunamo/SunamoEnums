namespace
#if SunamoDateTime
SunamoDateTime
#elif SunamoDevCode
SunamoDevCode
#elif SunamoLogMessage
SunamoLogMessage
#elif SunamoShared
SunamoShared
#elif SunamoThisApp
SunamoThisApp
#elif SunamoXlfKeys
SunamoXlfKeys
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoLang
SunamoLang
#elif SunamoData
SunamoData
#else
SunamoEnums
#endif
;

// Musí být ve SunamoEnums protože je sdílen např. i ve SunamoDateTime

/// <summary>
/// For projects for which is reference whole Xlf useless
/// But it is only one file (like here Langs), consider import it instead create standalone project
/// Tool which will copy it automatilly also could not be bad
/// </summary>
public enum Langs
{
    #region For easy copying to other files
    cs = 0,
    en = 1
    #endregion
}
