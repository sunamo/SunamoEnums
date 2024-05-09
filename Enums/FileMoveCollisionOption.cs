

namespace
#if SunamoDevCode
SunamoDevCode
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoHttp
SunamoHttp
#elif SunamoShared
SunamoShared
#else SunamoEnumsEnums
SunamoEnumsEnums
#endif
;
public enum FileMoveCollisionOption
{
    AddSerie,
    AddFileSize,
    Overwrite,
    DiscardFrom,
    LeaveLarger,
    DontManipulate
}
