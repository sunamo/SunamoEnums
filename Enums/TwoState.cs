namespace
#if SunamoLogging
SunamoLogging
#elif SunamoInterfaces
SunamoInterfaces
#else
SunamoEnums
#endif
;
public enum TwoState
{
    TrueFalse,
    AddRemove,
    AcceptDecline
}