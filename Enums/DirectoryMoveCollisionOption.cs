namespace
#if SunamoFileSystem
SunamoFileSystem
#elif SunamoDevCode
SunamoDevCode
#else
SunamoEnums
#endif
;
public enum DirectoryMoveCollisionOption
{
    AddSerie,
    Overwrite,
    DiscardFrom
}