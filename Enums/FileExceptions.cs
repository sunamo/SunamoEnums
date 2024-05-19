namespace
#if SunamoShared
SunamoShared
#else
SunamoEnums
#endif
;
public enum FileExceptions
{
    None,
    FileNotFound,
    UnauthorizedAccess,
    General
}