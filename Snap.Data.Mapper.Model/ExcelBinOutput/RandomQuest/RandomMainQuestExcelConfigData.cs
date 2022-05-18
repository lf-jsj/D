namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;
public class RandomMainQuestExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("luaPath")]
    public string LuaPath { get; set; } = default!;

    [JsonPropertyName("activeMode")]
    public string ActiveMode { get; set; } = default!;

    [JsonPropertyName("suggestTrackMainQuestList")]
    public IList<DataObject> SuggestTrackMainQuestList { get; set; } = default!;

    [JsonPropertyName("rewardIdList")]
    public string RewardIdList { get; set; } = default!;
}
