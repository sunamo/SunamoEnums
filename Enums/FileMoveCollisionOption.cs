

#if SunamoTestValues
namespace SunamoTestValues;
#else
namespace SunamoEnums.Enums;
#endif
public enum FileMoveCollisionOption
{
    AddSerie,
    AddFileSize,
    Overwrite,
    DiscardFrom,
    LeaveLarger,
    DontManipulate
}
