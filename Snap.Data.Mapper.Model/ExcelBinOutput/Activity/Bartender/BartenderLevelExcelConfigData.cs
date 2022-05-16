namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;

public class BartenderLevelExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public int LevelNameTextMapHash { get; set; }

    [JsonPropertyName("LKFNFPEJPJA")]
    public int LKFNFPEJPJA { get; set; }

    [JsonPropertyName("EAAIKOOCMPF")]
    public int EAAIKOOCMPF { get; set; }

    [JsonPropertyName("KKKODIHGEGE")]
    public IList<int> KKKODIHGEGE { get; set; } = default!;

    [JsonPropertyName("HHECOGFHLBH")]
    public int HHECOGFHLBH { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("HBHEINOLLML")]
    public Text HBHEINOLLML { get; set; }
}
