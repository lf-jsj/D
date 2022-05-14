namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.CrystalLink;

public class HPGLJGCCMFFODJBMAKLICP<T> : DataObject
{
    [JsonPropertyName("HPGLJGCCMFF")]
    public IList<T> HPGLJGCCMFF { get; set; } = default!;

    [JsonPropertyName("ODJBMAKLICP")]
    public IList<T> ODJBMAKLICP { get; set; } = default!;
}
