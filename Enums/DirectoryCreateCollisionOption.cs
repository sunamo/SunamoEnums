namespace
#if SunamoFileSystem
SunamoFileSystem
#elif SunamoShared
SunamoShared
#else
SunamoEnums
#endif
;
public enum DirectoryCreateCollisionOption
{
    Delete,
    Overwrite,
    AddSerie
}