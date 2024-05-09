namespace
#if SunamoFileSystem
SunamoFileSystem
#elif SunamoShared
SunamoShared
#else SunamoEnumsEnums
SunamoEnumsEnums
#endif
;

public enum DirectoryCreateCollisionOption
{
    Delete,
    Overwrite,
    AddSerie
}
