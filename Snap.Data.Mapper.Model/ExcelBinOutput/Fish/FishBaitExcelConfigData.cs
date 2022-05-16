namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class FishBaitExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("LLGFMGKCCFM")]
    public IList<LLGFMGKCCFM> LLGFMGKCCFM { get; set; } = default!;

    [JsonPropertyName("EKNKDGMIPEH")]
    public int EKNKDGMIPEH { get; set; }

    [JsonPropertyName("KBOEBDEPNIA")]
    public IList<int> KBOEBDEPNIA { get; set; } = default!;
}
