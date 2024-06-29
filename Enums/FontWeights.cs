namespace
#if SunamoInterfaces
SunamoInterfaces
#else
SunamoEnums
#endif
;
/// <summary>
/// Dříve FontWeight2
/// Ale nově žádný element nemůže končit 2, to nic neříká!
/// Proto FontWeight2 -> FontWeights
/// </summary>
public enum FontWeights : ushort
{
    light = 100,
    lighter = 250,
    normal = 400,
    bolder = 500,
    bold = 700,
    extraBold = 900
}