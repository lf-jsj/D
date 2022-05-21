namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldComfortLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelID")]
    public int LevelID { get; set; }

    [JsonPropertyName("homeCoinProduceRate")]
    public int HomeCoinProduceRate { get; set; }

    [JsonPropertyName("companionshipExpProduceRate")]
    public int CompanionshipExpProduceRate { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public Text LevelNameTextMapHash { get; set; }

    [JsonPropertyName("levelIconHashSuffix")]
    public HashSuffix LevelIconHashSuffix { get; set; }

    [JsonPropertyName("levelIconHashPre")]
    public HashPre LevelIconHashPre { get; set; }

    [JsonPropertyName("comfort")]
    public int? Comfort { get; set; }
}