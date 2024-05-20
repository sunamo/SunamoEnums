namespace
#if SunamoHtml
SunamoHtml
#elif SunamoWikipedia
SunamoWikipedia
#else
SunamoEnums
#endif
;
public enum HtmlTagSyntax
{
    Start,
    End,
    NonPairingEnded,
    NonPairingNotEnded
}