namespace
#if SunamoFileSystem
SunamoFileSystem
#elif SunamoShared
SunamoShared
#else
SunamoEnumsEnums
#endif
;

public enum DirectoryCreateCollisionOption
{
    Delete,
    Overwrite,
    AddSerie
}
