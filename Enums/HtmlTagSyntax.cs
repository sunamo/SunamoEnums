namespace
#if SunamoHtml
SunamoHtml
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