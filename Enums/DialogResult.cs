namespace
#if SunamoCl
SunamoCl
#elif SunamoInterfaces
SunamoInterfaces
#else
SunamoEnums
#endif
;
/// <summary>
///     Usage: cl.DoYouWantToContinue
/// </summary>
public enum DialogResult
{
    Yes,
    No
}