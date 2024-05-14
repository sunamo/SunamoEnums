namespace
#if SunamoLogger
SunamoLogger
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
