namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class TowerRewardExcelConfigData : DataObject
{
    [JsonPropertyName("OKPPDCCEILD")]
    public int OKPPDCCEILD { get; set; }

    [JsonPropertyName("OPNFONJOIAC")]
    public int OPNFONJOIAC { get; set; }

    [JsonPropertyName("AJPNJEMLIIC")]
    public int AJPNJEMLIIC { get; set; }

    [JsonPropertyName("GCLPEJEGICK")]
    public int GCLPEJEGICK { get; set; }

    [JsonPropertyName("HNONBMJIOEO")]
    public int HNONBMJIOEO { get; set; }

    [JsonPropertyName("JPDHCGFBDMI")]
    public IList<int> JPDHCGFBDMI { get; set; } = default!;
}
