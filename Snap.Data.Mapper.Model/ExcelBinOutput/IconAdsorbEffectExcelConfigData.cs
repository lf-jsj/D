namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class IconAdsorbEffectExcelConfigData : DataObject
{
    [JsonPropertyName("effectId")]
    public int EffectId { get; set; }

    [JsonPropertyName("iconIdList")]
    public IList<int> IconIdList { get; set; } = default!;
}