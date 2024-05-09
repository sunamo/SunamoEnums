namespace
#if SunamoCollectionOnDrive
SunamoCollectionOnDrive
#elif SunamoDevCode
SunamoDevCode
#elif SunamoFileIO
SunamoFileIO
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoHttp
SunamoHttp
#elif SunamoPlatformUwpInterop
SunamoPlatformUwpInterop
#elif SunamoShared
SunamoShared
#else SunamoEnumsEnums
SunamoEnumsEnums
#endif
;

public enum AppFolders
{
    #region Not backuped

    Logs,
    Output,
    Cache,
    Temp,

    #endregion

    #region Backuped

    Input,
    Settings,
    Data,
    Other,
    Controls,
    Local,
    Roaming,
    Crypted,
    Reports,
    Backup

    #endregion
}
