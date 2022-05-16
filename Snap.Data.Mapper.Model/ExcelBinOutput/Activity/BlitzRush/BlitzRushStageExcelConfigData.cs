namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BlitzRush;

public class BlitzRushStageExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("AMNLHMAFIBH")]
    public Text AMNLHMAFIBH { get; set; }

    [JsonPropertyName("HHHBHGJKIIL")]
    public Text HHHBHGJKIIL { get; set; }

    [JsonPropertyName("KCJJDLNNFCC")]
    public Text KCJJDLNNFCC { get; set; }

    [JsonPropertyName("OIKNLDIHHMJ")]
    public int OIKNLDIHHMJ { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }
}