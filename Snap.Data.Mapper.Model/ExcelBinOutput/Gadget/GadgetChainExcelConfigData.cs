namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;
public class GadgetChainExcelConfigData : DataObject
{
    [JsonPropertyName("EOGKGKLLDAC")]
    public int EOGKGKLLDAC { get; set; }

    [JsonPropertyName("DJIGCOELMCK")]
    public int DJIGCOELMCK { get; set; }

    [JsonPropertyName("maxLevel")]
    public int MaxLevel { get; set; }

    [JsonPropertyName("buffList")]
    public IList<int> BuffList { get; set; } = default!;
}
